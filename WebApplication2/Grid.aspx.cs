using Autofac;
using System;
using System.Collections.Generic;
using WebApplication2.Models;
namespace WebApplication2
{
    public partial class WebForm1 : BasePage
    {
        public DalPeople DalPeople { get; set; }
        private readonly int PageSize = 10;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);
            DalPeople = Scope.Resolve<DalPeople>();
        }

        protected void GridPeople(int pageIndex = 0, int pageSize = 10)
        {
            var result = DalPeople.GetPages(pageIndex * pageSize, pageSize);
            GridViewPeople.PageSize = PageSize;
            GridViewPeople.VirtualItemCount = result.Count;            
            GridViewPeople.DataSource = result.Items;
            GridViewPeople.DataBind();
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GridPeople(pageSize: PageSize);
            }
        }

        protected void GridViewPeople_PageIndexChanging(object sender, System.Web.UI.WebControls.GridViewPageEventArgs e)
        {
            GridViewPeople.PageIndex = e.NewPageIndex;
            int offset = GridViewPeople.PageIndex;
            int pageSize = GridViewPeople.PageSize;
            GridPeople(offset, pageSize);
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            DalPeople.Add(TxtName.Text);
            TxtName.Text = string.Empty;
            Alert.Show(this, GetType(), "Registro salvo com sucesso!");
            GridViewPeople.PageIndex = 0;
            GridPeople(pageSize: PageSize);
        }
    }
}