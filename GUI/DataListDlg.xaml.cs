using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Panuon.UI.Silver;
namespace GeoDCNN.GUI
{
    /// <summary>
    /// DataListDlg.xaml 的交互逻辑
    /// </summary>
    public partial class DataListDlg : WindowX
    {
        public DataListDlg(WindowX Parent)
        {
            InitializeComponent();
            this.Owner = Parent;

            //DataTable dataTable = new DataTable("Dataset");
            //dataTable.Columns.Add("路径", Type.GetType("System.String"));
            //dataTable.Columns.Add("文件名", Type.GetType("System.String"));
            //dataTable.Columns.Add("类型", Type.GetType("System.String"));
            //dataTable.Columns.Add("格式", Type.GetType("System.String"));
            //dataTable.Columns.Add("顺序", Type.GetType("System.String"));
            //dataTable.Columns.Add("显示", Type.GetType("System.String"));
            //DataListGrid.ItemsSource = dataTable.DefaultView;
        }
    }
}
