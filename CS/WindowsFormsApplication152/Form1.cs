using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Data.Filtering;
using System.Collections;
using DevExpress.XtraEditors;
using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors.Filtering;
using DevExpress.XtraEditors.Repository;
using DevExpress.Data.Filtering.Helpers;

namespace DXSample
{
    public partial class Form1 : XtraForm
    {
        public Form1()
        {
            InitializeComponent();
        }

        IQueryable<Products> source;
        private void OnLoad(object sender, EventArgs e)
        {
            var products = new XPQuery<Products>(unitOfWork1);
            
            source = from product in products
                          where product.Quantity >= 20
                          select product;
           
            gridControl1.DataSource = source.ToList();
            CreateFilterColumns();
        }

        private void CreateFilterColumns()
        {
            filterControl1.FilterColumns.Add(new UnboundFilterColumn("ProductID", "ProductID", typeof(int),
                new RepositoryItemSpinEdit(), FilterColumnClauseClass.Generic));
            filterControl1.FilterColumns.Add(new UnboundFilterColumn("Quantity", "Quantity", typeof(int),
                new RepositoryItemSpinEdit(), FilterColumnClauseClass.Generic));
            filterControl1.FilterColumns.Add(new UnboundFilterColumn("Price", "Price", typeof(decimal),
               new RepositoryItemSpinEdit(), FilterColumnClauseClass.Generic));
            filterControl1.FilterColumns.Add(new UnboundFilterColumn("ProductName", "ProductName", typeof(string),
               new RepositoryItemTextEdit(), FilterColumnClauseClass.String));
            filterControl1.FilterColumns.Add(new UnboundFilterColumn("Discontinued", "Discontinued", typeof(bool),
               new RepositoryItemCheckEdit(), FilterColumnClauseClass.Generic));
        }

        private void OnUpdateFilter(object sender, EventArgs e)
        {
            gridControl1.BeginUpdate();
            try
            {
                IQueryable<Products> filteredData = source.AppendWhere(filterControl1.FilterCriteria) as IQueryable<Products>;
                gridControl1.DataSource = null;
                gridControl1.DataSource = filteredData.ToList();
            }
            finally
            {
                gridControl1.EndUpdate();
            }
        }

        private void OnSaveButtonClick(object sender, EventArgs e)
        {
            try
            {
                unitOfWork1.CommitChanges();
            }
            catch (Exception exc){
                MessageBox.Show(exc.ToString());
                unitOfWork1.ReloadChangedObjects();
            }
        }
    }
}
