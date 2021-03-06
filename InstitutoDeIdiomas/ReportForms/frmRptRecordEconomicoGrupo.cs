﻿using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InstitutoDeIdiomas.ReportForms
{
    public partial class frmRptRecordEconomicoGrupo : MaterialForm
    {
        DataTable dt;
        string idioma, nivel, ciclo, docente, salon, horaInicio, horaFin, numero, inicio, fin, dias;

        public frmRptRecordEconomicoGrupo(DataTable dt, string idioma, string nivel, string ciclo, string docente,
            string salon, string horaInicio, string horaFin, string numero,
            string inicio, string fin, string dias)
        {
            InitializeComponent();
            this.dt = dt;
            this.idioma = idioma;
            this.nivel = nivel;
            this.ciclo = ciclo;
            this.docente = docente;
            this.salon = salon;
            this.horaInicio = horaInicio;
            this.horaFin = horaFin;
            this.numero = numero;
            this.inicio = inicio;
            this.fin = fin;
            this.dias = dias;
        }

        private void frmRptRecordEconomicoGrupo_Load(object sender, EventArgs e)
        {
            ReportDataSource rds = new ReportDataSource("dsRecord", dt);
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("pIdioma",idioma),
                new Microsoft.Reporting.WinForms.ReportParameter("pNivel",nivel),
                new Microsoft.Reporting.WinForms.ReportParameter("pCiclo",ciclo),
                new Microsoft.Reporting.WinForms.ReportParameter("pDocente",docente),
                new Microsoft.Reporting.WinForms.ReportParameter("pSalon",salon),
                new Microsoft.Reporting.WinForms.ReportParameter("pHoraInicio",horaInicio),
                new Microsoft.Reporting.WinForms.ReportParameter("pHoraFin",horaFin),
                new Microsoft.Reporting.WinForms.ReportParameter("pNumero",numero),
                new Microsoft.Reporting.WinForms.ReportParameter("pInicio",inicio),
                new Microsoft.Reporting.WinForms.ReportParameter("pFin",fin),
                new Microsoft.Reporting.WinForms.ReportParameter("pDias",dias)
            };
            this.reportViewer1.LocalReport.SetParameters(para);
            this.reportViewer1.LocalReport.DataSources.Add(rds);
            this.reportViewer1.RefreshReport();
        }

        
    }
}
