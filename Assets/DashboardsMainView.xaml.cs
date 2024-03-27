#if UNITY_5_3_OR_NEWER
#define NOESIS
using Dashboards.Assets.ViewModels;
using Noesis;
#else
using Dashboards.Assets.ViewModels;
using System;
using System.Windows.Controls;
#endif

namespace Dashboards
{
    /// <summary>
    /// Interaction logic for DashboardsMainView.xaml
    /// </summary>
    public partial class DashboardsMainView : Page
    {
        DashboardViewModel viewModel;
        public DashboardsMainView()
        {
            InitializeComponent();
            viewModel = new DashboardViewModel();
            this.DataContext = viewModel;
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }
#endif
    }
}
