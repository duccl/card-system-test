using System.Windows.Forms;
using acme_flight_system.Models;

namespace acme_flight_system
{
    public partial class AcmeForm : Form
    {
        private DataBaseManager dataBaseManager;
        private System.Collections.Generic.List<VooModel> todos_voos_registrados;
        private bool flight_selected;
        public AcmeForm()
        {
            InitializeComponent();
            dataBaseManager = new DataBaseManager("acme_database");
            PopulateFlightDataGridView();
        }

        public async void PopulateFlightDataGridView()
        {
            todos_voos_registrados = await dataBaseManager.ResgataTodosRegistrosDeVoos();
            flightDataGridView.DataSource = todos_voos_registrados;
        }

        private char GetCheckedBox()
        {
            if (sim_checkBox.Checked && !nao_checkBox.Checked)
            {
                return 'S';
            }
            else if( !sim_checkBox.Checked && nao_checkBox.Checked)
            {
                return 'N';
            }
            return '0';
        }

        private void ClearFormData()
        {
            foreach (var controle in dataFormPanel.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Clear();
                }
                else if (controle is NumericUpDown)
                {
                    ((NumericUpDown)controle).Value = ((NumericUpDown)controle).Minimum;
                }
                else if (controle is CheckBox)
                {
                    ((CheckBox)controle).Checked = false;
                }
            }
        }

        private int RetrieveLastFlightId()
        {
            return todos_voos_registrados.Count != 0 ? todos_voos_registrados[todos_voos_registrados.Count - 1].ID_VOO : 0;
        }

        private void ToggleButton(Button button)
        {
            button.Enabled = !button.Enabled;
        }

        private void incluir_button_Click(object sender, System.EventArgs e)
        {
            ResetDataForm();
        }

        private void ResetDataForm()
        {
            ClearFormData();
            ToggleButton(salvar_button);
            ToggleButton(cancelar_button);
            flight_selected = false;
        }

        private VooModel RetriveFlightOfForm()
        {
            char checked_box_captura = GetCheckedBox();
            if (checked_box_captura == '0')
            {
                MessageBox.Show(new Form { TopMost = true }, "Apenas uma opção deve ser selecionada! Tente novamente");
                return null;
            }
            VooModel voo = new VooModel
            {
                Custo = (double)custo_numericUpDown.Value,
                Data_voo = dataVoo_dateTimePicker.Value,
                Nivel_dor = (int)nivelDor_numericUpDown.Value,
                Distancia = (int)distancia_numericUpDown.Value,
                Captura = checked_box_captura,
            };
            return voo;
        }

        private void PopulateForm(VooModel voo)
        {
            custo_numericUpDown.Value = (decimal)voo.Custo;
            dataVoo_dateTimePicker.Value = voo.Data_voo;
            nivelDor_numericUpDown.Value = (decimal)voo.Nivel_dor;
            distancia_numericUpDown.Value = (decimal)voo.Distancia;
            if (voo.Captura == 'S')
            {
                sim_checkBox.Checked = true;
                nao_checkBox.Checked = false;
            }
            else
            {
                nao_checkBox.Checked = true;
                sim_checkBox.Checked = false;
            }
        }

        private void salvar_button_Click(object sender, System.EventArgs e)
        {
            var voo = RetriveFlightOfForm();
            if (voo == null) return;

            if (flight_selected)
            {
                voo.ID_VOO = flightDataGridView.CurrentRow.Index + 1;
                dataBaseManager.UpdateVoo(voo, () => PopulateFlightDataGridView());
            }
            else
            {
                voo.ID_VOO += RetrieveLastFlightId() + 1;
                dataBaseManager.AdicionaVoo(voo, () => PopulateFlightDataGridView());
            }
            ResetDataForm();
        }

        private void excluir_button_Click(object sender, System.EventArgs e)
        {
            var voo = RetriveFlightOfForm();
            if (voo == null) return;
            dataBaseManager.DeleteVoo(voo,() => PopulateFlightDataGridView());
            ResetDataForm();
        }

        private void cancelar_button_Click(object sender, System.EventArgs e)
        {
            ResetDataForm();
        }

        private void flightDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedFlight = (VooModel)flightDataGridView.CurrentRow.DataBoundItem;
            flight_selected = true;
            PopulateForm(selectedFlight);
        }
    }
}
