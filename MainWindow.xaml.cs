using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Panuon.UI.Silver;
using Esri.ArcGISRuntime.Mapping;
using Esri.ArcGISRuntime.Geometry;
using Microsoft.Win32;
using GeoDCNN.GUI;
using Temp;
namespace GeoDCNN
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : WindowX
    {
        #region 加载窗口控件
        #endregion

        public MainWindow()
        {
            InitializeComponent();       
        }

        private void TreeViewItem_PreviewMouseLeftButtonDown_1(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateStreets();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_2(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateStreetsVector();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_3(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateStreetsNightVector();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_4(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateImagery();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_5(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateImageryWithLabels();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_6(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateImageryWithLabelsVector();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_7(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateDarkGrayCanvasVector();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_8(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateLightGrayCanvas();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_9(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateLightGrayCanvasVector();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_10(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateNavigationVector();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_11(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateOpenStreetMap();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_12(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateOceans();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_13(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateTopographic();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }
        private void TreeViewItem_PreviewMouseLeftButtonDown_14(object sender, MouseButtonEventArgs e)
        {
            Map myMap = new Map();
            myMap.Basemap = Basemap.CreateTopographicVector();
            // Assign the map to the MapView
            MyMapView.Map = myMap;
        }

        private void TreeViewItem_PreviewMouseLeftButtonDown_loaddata(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "Raster (*.tif,*.jpg,*.bmp,*.png)|*.tif,*.tiff,*.jpg,*.bmp,*.png|Shapefile(*.shp)|*.shp|All Files(*.*)|*.*";
            dialog.Title = "加载文件";
            dialog.Multiselect = true;
            if (dialog.ShowDialog() == true)
            {
                string[] files = dialog.FileNames;
            }
        }

        private void TreeViewItem_PreviewMouseLeftButtonDown_datalist(object sender, MouseButtonEventArgs e)
        {
            DataManageDlg dataDlg = new DataManageDlg();
            dataDlg.Show();
        }

        private void WindowX_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void MyMapView_MouseMove(object sender, MouseEventArgs e)
        {
            String LocationTemplate = "经度:{0} 纬度:{1}";
            var _currentLatLng = MyMapView.ScreenToLocation(e.GetPosition(MyMapView));
            if (_currentLatLng != null)
            {
                StatusLocationLabel.Visibility = Visibility.Visible;
                var normalizedPoint = GeometryEngine.NormalizeCentralMeridian(_currentLatLng);
                var projectedCenter = GeometryEngine.Project(normalizedPoint, SpatialReferences.Wgs84) as MapPoint;
                StatusLocationLabel.Content = String.Format(LocationTemplate, projectedCenter.X.ToString(), projectedCenter.Y.ToString());
            }
        }

        private void TreeViewItem_PreviewMouseLeftButtonDown_py(object sender, MouseButtonEventArgs e)
        {
            Temp.PyEnvDlg pyuDlg = new Temp.PyEnvDlg();
            pyuDlg.Show();
        }

        private void TreeViewItem_PreviewMouseLeftButtonDown_gpu(object sender, MouseButtonEventArgs e)
        {
            Temp.GPUDlg GpuDlg = new Temp.GPUDlg();
            GpuDlg.Show();
        }

        private void TreeViewItem_PreviewMouseLeftButtonDown_outfall(object sender, MouseButtonEventArgs e)
        {
            OutfallsDlg outDlg = new Temp.OutfallsDlg();
            outDlg.Show();
        }
    }
}
