using SistemaDeVentas.Ubication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaDeVentas.Clientes
{
    public partial class AddClientForm : Form
    {

        public AddClientForm()
        {
            InitializeComponent();
        }

        private void btn_add_client_Click(object sender, EventArgs e)
        {

            //validar que el nombre no este vacio
            if (txt_name.Text == "")
            {
                MessageBox.Show("El nombre no puede estar vacío");
                return;
            }

            ClientRepository clientRepository = new ClientRepository();
            Client client = new Client();
            client.Name = txt_name.Text;
            client.Address = txt_address.Text;
            client.Document = txt_document.Text;
            client.Phone = txt_phone.Text;
            client.Reference = txt_reference.Text;
            client.Department = cb_department.Text.Trim();
            client.Province = cb_province.Text;
            client.District = cb_district.Text;
            clientRepository.InsertClient(client);
            this.Close();

        }

        private void ClientesForm_Load(object sender, EventArgs e)
        {
            // que solo permita usar los valores de la lista de los combobox
            cb_department.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_province.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_district.DropDownStyle = ComboBoxStyle.DropDownList;


            //cargar datos de department repository a cb_department
            DepartmentRepository departmentRepository = new DepartmentRepository();
            List<Department> departments = departmentRepository.GetAllDepartments();
            foreach (Department department in departments)
            {
                cb_department.Items.Add(department.Name);
            }
            cb_department.SelectedIndex = 0;
        }

        private void cb_department_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargar datos de province repository a cb_province
            ProvinceRepository provinceRepository = new ProvinceRepository();
            List<Province> provinces = provinceRepository.GetProvincesByDepartment(cb_department.Text);
            cb_province.Items.Clear();
            foreach (Province province in provinces)
            {
                cb_province.Items.Add(province.Name);
            }
            cb_province.SelectedIndex = 0;

        }


        private void cb_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cargar datos de district repository a cb_district
            DistrictRepository districtRepository = new DistrictRepository();
            List<District> districts = districtRepository.GetDistrictsByProvince(cb_province.Text);
            cb_district.Items.Clear();
            foreach (District district in districts)
            {
                cb_district.Items.Add(district.Name);
            }
            cb_district.SelectedIndex = 0;
        }

    }
}
