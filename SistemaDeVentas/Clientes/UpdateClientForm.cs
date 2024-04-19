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
    public partial class UpdateClientForm : Form
    {
        Client client;
        public UpdateClientForm(Client client)
        {
            InitializeComponent();
            this.client = client;
        }

        private void UpdateClientForm_Load(object sender, EventArgs e)
        {
            txt_name.Text = client.Name;
            txt_address.Text = client.Address;
            txt_document.Text = client.Document;
            txt_phone.Text = client.Phone;
            txt_reference.Text = client.Reference;
            cb_department.Text = client.Department;

            DepartmentRepository departmentRepository = new DepartmentRepository();
            List<Department> departments = departmentRepository.GetAllDepartments();
            foreach (Department department in departments)
            {
                cb_department.Items.Add(department.Name);

            }
            cb_department.DropDownStyle = ComboBoxStyle.DropDownList;
            cb_department.Text = client.Department;

            ProvinceRepository provinceRepository = new ProvinceRepository();
            List<Province> provinces = provinceRepository.GetProvincesByDepartment(cb_department.Text);
            cb_province.Items.Clear();
            foreach (Province province in provinces)
            {
                cb_province.Items.Add(province.Name);
            }
            cb_province.Text = client.Province;
            cb_province.DropDownStyle = ComboBoxStyle.DropDownList;

            DistrictRepository districtRepository = new DistrictRepository();
            List<District> districts = districtRepository.GetDistrictsByProvince(cb_province.Text);
            cb_district.Items.Clear();
            foreach (District district in districts)
            {
                cb_district.Items.Add(district.Name);
            }
            cb_district.Text = client.District;
            cb_district.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btn_edit_client_Click(object sender, EventArgs e)
        {
            client.Name = txt_name.Text;
            client.Address = txt_address.Text;
            client.Document = txt_document.Text;
            client.Phone = txt_phone.Text;
            client.Reference = txt_reference.Text;
            client.Department = cb_department.Text;
            client.Province = cb_province.Text;
            client.District = cb_district.Text;

            ClientRepository clientRepository = new ClientRepository();
            clientRepository.UpdateClient(client);
            this.Close();

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

        private void btn_add_client_Click(object sender, EventArgs e)
        {

        }

        private void cb_department_SelectedIndexChanged_1(object sender, EventArgs e)
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

        private void cb_province_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //cargo datos de district repository a cb_district
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
