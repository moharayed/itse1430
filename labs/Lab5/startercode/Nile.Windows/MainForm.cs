/*
 * Mohammed Rayed
 * Lab 4
 * ITSE 1430
 */
using System;
using System.ComponentModel.DataAnnotations;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using Nile.Stores.Sql;

namespace Nile.Windows
{
    public partial class MainForm : Form
    {
        #region Construction

        public MainForm()
        {
            InitializeComponent();
        }
        #endregion

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            _gridProducts.AutoGenerateColumns = false;

            var connString = ConfigurationManager.ConnectionStrings["ProductDatabase"];
            _database = new SqlProductDatabase (connString.ConnectionString);

            UpdateList ();
        }

        #region Event Handlers
        
        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnProductAdd( object sender, EventArgs e )
        {
            var child = new ProductDetailForm("Product Details");
            if (child.ShowDialog (this) != DialogResult.OK)
                return;

            try
            {
                _database.Add (child.Product);
                UpdateList ();
            } catch (ArgumentException ex)
            {
                MessageBox.Show (ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (ValidationException ex)
            {
                MessageBox.Show (ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception)
            {
                MessageBox.Show ("Save failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OnProductEdit( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
            {
                MessageBox.Show("No products available.");
                return;
            };

            EditProduct(product);
        }        

        private void OnProductDelete( object sender, EventArgs e )
        {
            var product = GetSelectedProduct();
            if (product == null)
                return;

            DeleteProduct(product);
        }        
                
        private void OnEditRow( object sender, DataGridViewCellEventArgs e )
        {
            var grid = sender as DataGridView;

            //Handle column clicks
            if (e.RowIndex < 0)
                return;

            var row = grid.Rows[e.RowIndex];
            var item = row.DataBoundItem as Product;

            if (item != null)
                EditProduct(item);
        }

        private void OnKeyDownGrid( object sender, KeyEventArgs e )
        {
            if (e.KeyCode != Keys.Delete)
                return;

            var product = GetSelectedProduct();
            if (product != null)
                DeleteProduct(product);
			
			//Don't continue with key
            e.SuppressKeyPress = true;
        }

        #endregion

        #region Private Members

        private void DeleteProduct ( Product product )
        {
            //Confirm
            if (MessageBox.Show(this, $"Are you sure you want to delete '{product.Name}'?",
                                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                return;

            try
            {
                _database.Remove (product.Id);
                UpdateList ();
            } catch (ArgumentException ex)
            {
                MessageBox.Show (ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (ValidationException ex)
            {
                MessageBox.Show (ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception)
            {
                MessageBox.Show ("Save failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditProduct ( Product product )
        {
            var child = new ProductDetailForm("Product Details");
            child.Product = product;
            if (child.ShowDialog(this) != DialogResult.OK)
                return;

            try
            {
                //Save product
                _database.Update (child.Product);
                UpdateList ();
            } catch (ArgumentException ex)
            {
                MessageBox.Show (ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (ValidationException ex)
            {
                MessageBox.Show (ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception)
            {
                MessageBox.Show ("Save failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private Product GetSelectedProduct ()
        {
            if (_gridProducts.SelectedRows.Count > 0)
                return _gridProducts.SelectedRows[0].DataBoundItem as Product;

            return null;
        }

        private void UpdateList ()
        {
            try
            {
                var products = from p in _database.GetAll ()
                               orderby p.Name
                               select p;
                _bsProducts.DataSource = products.ToArray ();

            } catch (ArgumentException ex)
            {
                MessageBox.Show (ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (ValidationException ex)
            {
                MessageBox.Show (ex.Message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } catch (Exception)
            {
                MessageBox.Show ("Save failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private IProductDatabase _database;
        #endregion

        private void OnHelpAbout ( object sender, EventArgs e )
        {
            var form = new AboutForm ();
            form.ShowDialog (this);
        }
    }
}
