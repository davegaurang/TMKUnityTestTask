#if UNITY_5_3_OR_NEWER
#define NOESIS
using Noesis;
#else
using System;
using System.Windows.Controls;
#endif

namespace TMKUnityTestTask
{
    /// <summary>
    /// Interaction logic for TMKUnityTestTaskMainView.xaml
    /// </summary>
    public partial class TMKUnityTestTaskMainView : UserControl
    {
        public TMKUnityTestTaskMainView()
        {
            InitializeComponent();
        }

#if NOESIS
        private void InitializeComponent()
        {
            NoesisUnity.LoadComponent(this);
        }
#endif
    }
}
