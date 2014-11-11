using CheckersApp.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Diagnostics;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace CheckersApp
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Windows.UI.Xaml.Shapes.Rectangle moveFromSpace = null;
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        /// <summary>
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// NavigationHelper is used on each page to aid in navigation and 
        /// process lifetime management
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }


        public MainPage()
        {
            this.InitializeComponent();
            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += navigationHelper_LoadState;
            this.navigationHelper.SaveState += navigationHelper_SaveState;
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// 
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
        /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            navigationHelper.OnNavigatedFrom(e);
        }

        #endregion

        private void Space_Tapped(object sender, TappedRoutedEventArgs e)
        {
            if (moveFromSpace == null)
            {
                moveFromSpace = (Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource;
            }
            else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space1)
            {
                Debug.WriteLine(e.OriginalSource.ToString());
            }
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space2)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space3)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space4)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space5)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space6)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space7)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space8)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space9)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space10)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space11)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space12)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space13)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space14)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space15)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space16)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space17)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space18)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space19)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space20)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space21)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space22)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space23)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space24)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space25)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space26)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space27)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space28)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space29)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space30)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space31)
            //{

            //}
            //else if ((Windows.UI.Xaml.Shapes.Rectangle)e.OriginalSource == Space32)
            //{

            //}
        }

        private bool CanMoveBeMade(Windows.UI.Xaml.Shapes.Rectangle Start, Windows.UI.Xaml.Shapes.Rectangle End)
        {
            bool result = false;

            return result;
        }
    }
}
