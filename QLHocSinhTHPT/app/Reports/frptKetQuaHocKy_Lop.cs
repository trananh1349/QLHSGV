using System;
using System.Text;
using System.Drawing;
using app.Bussiness;
using app.Component;
using app.Controller;
using DevComponents.DotNetBar;
using System.Collections.Generic;
using Microsoft.Reporting.WinForms;

namespace app.Reports
{
    public partial class frptKetQuaHocKy_Lop : Office2007Form
    {
        #region Fields
        NamHocCtrl  m_NamHocCtrl    = new NamHocCtrl();
        HocKyCtrl   m_HocKyCtrl     = new HocKyCtrl();
        LopCtrl     m_LopCtrl       = new LopCtrl();
        #endregion

        #region Constructor
        public frptKetQuaHocKy_Lop()
        {
            InitializeComponent();
            DataService.OpenConnection();
        }
        #endregion

        #region Load
        private void frptKetQuaHocKy_Lop_Load(object sender, EventArgs e)
        {
            m_NamHocCtrl.HienThiComboBox(cmbNamHoc);
            m_HocKyCtrl.HienThiComboBox(cmbHocKy);
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
        }
        #endregion

        #region SelectedIndexChanged event
        private void cmbNamHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbNamHoc.SelectedValue != null)
                m_LopCtrl.HienThiComboBox(cmbNamHoc.SelectedValue.ToString(), cmbLop);
            cmbLop.DataBindings.Clear();
        }
        #endregion

        #region Click event
        private void btnXem_Click(object sender, EventArgs e)
        {
        }
        #endregion
    }
}