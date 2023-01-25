using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreManagement.Controller
{
    class ControllerCategory
    {
        Model.ModelCategory modelCategory;
        View.ViewCategory viewCategory;

        public ControllerCategory(View.ViewCategory viewCategory)
        {
            modelCategory = new Model.ModelCategory();
            this.viewCategory = viewCategory;
        }
        public void reqId()
        {
            modelCategory.updateIdCategory();
            viewCategory.txtIdCategory.Text = modelCategory.idTemp;
        }
        public void reqData()
        {
            modelCategory.updateDataCategory();
            viewCategory.dataCategory.AutoGenerateColumns = false;
            viewCategory.dataCategory.DataSource = modelCategory.dataTempCategory;
        }
        public void reqSaveData()
        {
            modelCategory.idCategoryTemp = viewCategory.txtIdCategory.Text;
            modelCategory.nameCategoryTemp = viewCategory.txtNameCategory.Text;
            modelCategory.saveDataCategory();
        }
        public void reqUpdateData()
        {
            modelCategory.idCategoryTemp = viewCategory.txtIdCategory.Text;
            modelCategory.nameCategoryTemp = viewCategory.txtNameCategory.Text;
            modelCategory.editDataCategory();
        }
        public void reqRemoveData()
        {
            modelCategory.idCategoryTemp = viewCategory.txtIdCategory.Text;
            modelCategory.nameCategoryTemp = viewCategory.txtNameCategory.Text;
            modelCategory.removeDataCategory();
        }
        public void reqClearData()
        {
            viewCategory.txtIdCategory.Text = "";
            viewCategory.txtNameCategory.Text = "";
        }
        public void reqSearchId()
        {
            modelCategory.idCategoryTemp = viewCategory.txtIdCategory.Text;
            modelCategory.searchIdCategory();
            viewCategory.txtIdCategory.Text = modelCategory.idCategoryTemp;
            viewCategory.txtNameCategory.Text = modelCategory.nameCategoryTemp;
        }
        public void reqSearchName()
        {
            modelCategory.nameCategoryTemp = viewCategory.txtNameCategory.Text;
            modelCategory.searchNameCategory();
            viewCategory.txtIdCategory.Text = modelCategory.idCategoryTemp;
            viewCategory.txtNameCategory.Text = modelCategory.nameCategoryTemp;
        }
        public void reqCellCategory()
        {
            modelCategory.tempDataCategory = viewCategory.dataCategory;
            modelCategory.indexCategory = viewCategory.tempIndex;
            modelCategory.cellDataCategory();
            viewCategory.txtIdCategory.Text = modelCategory.idCategoryTemp;
            viewCategory.txtNameCategory.Text = modelCategory.nameCategoryTemp;
            
        }
        public void reqClear()
        {
            viewCategory.txtIdCategory.Clear();
            viewCategory.txtNameCategory.Clear();
            this.reqId();
        }
    }
}
