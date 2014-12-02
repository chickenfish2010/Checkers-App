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
        char[] startingSpace = new char[2];
        char[] destinationSpace = new char[2];
        int firstClick = 0;
        bool northPlayersTurn = true;

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
            if(firstClick == 0)
            {            
                if (sender == _00)
                {
                    startingSpace[0] = '0';
                    startingSpace[1] = '0';
                    firstClick = 1;
                }
                else if (sender == _01)
                {
                    startingSpace[0] = '0';
                    startingSpace[1] = '1';
                    firstClick = 1;
                }
                else if (sender == _02)
                {
                    startingSpace[0] = '0';
                    startingSpace[1] = '2';
                    firstClick = 1;
                }
                else if (sender == _03)
                {
                    startingSpace[0] = '0';
                    startingSpace[1] = '3';
                    firstClick = 1;
                }
                else if (sender == _10)
                {
                    startingSpace[0] = '1';
                    startingSpace[1] = '0';
                    firstClick = 1;
                }
                else if (sender == _11)
                {
                    startingSpace[0] = '1';
                    startingSpace[1] = '1';
                    firstClick = 1;
                }
                else if (sender == _12)
                {
                    startingSpace[0] = '1';
                    startingSpace[1] = '2';
                    firstClick = 1;
                }
                else if (sender == _13)
                {
                    startingSpace[0] = '1';
                    startingSpace[1] = '3';
                    firstClick = 1;
                }
                else if (sender == _20)
                {
                    startingSpace[0] = '2';
                    startingSpace[1] = '0';
                    firstClick = 1;
                }
                else if (sender == _21)
                {
                    startingSpace[0] = '2';
                    startingSpace[1] = '1';
                    firstClick = 1;
                }
                else if (sender == _22)
                {
                    startingSpace[0] = '2';
                    startingSpace[1] = '2';
                    firstClick = 1;
                }
                else if (sender == _23)
                {
                    startingSpace[0] = '2';
                    startingSpace[1] = '3';
                    firstClick = 1;
                }
                else if (sender == _30)
                {
                    startingSpace[0] = '3';
                    startingSpace[1] = '0';
                    firstClick = 1;
                }
                else if (sender == _31)
                {
                    startingSpace[0] = '3';
                    startingSpace[1] = '1';
                    firstClick = 1;
                }
                else if (sender == _32)
                {
                    startingSpace[0] = '3';
                    startingSpace[1] = '2';
                    firstClick = 1;
                }
                else if (sender == _33)
                {
                    startingSpace[0] = '3';
                    startingSpace[1] = '3';
                    firstClick = 1;
                }
                else if (sender == _40)
                {
                    startingSpace[0] = '4';
                    startingSpace[1] = '0';
                    firstClick = 1;
                }
                else if (sender == _41)
                {
                    startingSpace[0] = '4';
                    startingSpace[1] = '1';
                    firstClick = 1;
                }
                else if (sender == _42)
                {
                    startingSpace[0] = '4';
                    startingSpace[1] = '2';
                    firstClick = 1;
                }
                else if (sender == _43)
                {
                    startingSpace[0] = '4';
                    startingSpace[1] = '3';
                    firstClick = 1;
                }
                else if (sender == _50)
                {
                    startingSpace[0] = '5';
                    startingSpace[1] = '0';
                    firstClick = 1;
                }
                else if (sender == _51)
                {
                    startingSpace[0] = '5';
                    startingSpace[1] = '1';
                    firstClick = 1;
                }
                else if (sender == _52)
                {
                    startingSpace[0] = '5';
                    startingSpace[1] = '2';
                    firstClick = 1;
                }
                else if (sender == _53)
                {
                    startingSpace[0] = '5';
                    startingSpace[1] = '3';
                    firstClick = 1;
                }
                else if (sender == _60)
                {
                    startingSpace[0] = '6';
                    startingSpace[1] = '0';
                    firstClick = 1;
                }
                else if (sender == _61)
                {
                    startingSpace[0] = '6';
                    startingSpace[1] = '1';
                    firstClick = 1;
                }
                else if (sender == _62)
                {
                    startingSpace[0] = '6';
                    startingSpace[1] = '2';
                    firstClick = 1;
                }
                else if (sender == _63)
                {
                    startingSpace[0] = '6';
                    startingSpace[1] = '3';
                    firstClick = 1;
                }
                else if (sender == _70)
                {
                    startingSpace[0] = '7';
                    startingSpace[1] = '0';
                    firstClick = 1;
                }
                else if (sender == _71)
                {
                    startingSpace[0] = '7';
                    startingSpace[1] = '1';
                    firstClick = 1;
                }
                else if (sender == _72)
                {
                    startingSpace[0] = '7';
                    startingSpace[1] = '2';
                    firstClick = 1;
                }
                else if (sender == _73)
                {
                    startingSpace[0] = '7';
                    startingSpace[1] = '3';
                    firstClick = 1;
                }
            }
            else if (firstClick == 1)
            {
                if (sender == _00)
                {
                    destinationSpace[0] = '0';
                    destinationSpace[1] = '0';
                    firstClick = 0;
                }
                else if (sender == _01)
                {
                    destinationSpace[0] = '0';
                    destinationSpace[1] = '1';
                    firstClick = 0;
                }
                else if (sender == _02)
                {
                    destinationSpace[0] = '0';
                    destinationSpace[1] = '2';
                    firstClick = 0;
                }
                else if (sender == _03)
                {
                    destinationSpace[0] = '0';
                    destinationSpace[1] = '3';
                    firstClick = 0;
                }
                else if (sender == _10)
                {
                    destinationSpace[0] = '1';
                    destinationSpace[1] = '0';
                    firstClick = 0;
                }
                else if (sender == _11)
                {
                    destinationSpace[0] = '1';
                    destinationSpace[1] = '1';
                    firstClick = 0;
                }
                else if (sender == _12)
                {
                    destinationSpace[0] = '1';
                    destinationSpace[1] = '2';
                    firstClick = 0;
                }
                else if (sender == _13)
                {
                    destinationSpace[0] = '1';
                    destinationSpace[1] = '3';
                    firstClick = 0;
                }
                else if (sender == _20)
                {
                    destinationSpace[0] = '2';
                    destinationSpace[1] = '0';
                    firstClick = 0;
                }
                else if (sender == _21)
                {
                    destinationSpace[0] = '2';
                    destinationSpace[1] = '1';
                    firstClick = 0;
                }
                else if (sender == _22)
                {
                    destinationSpace[0] = '2';
                    destinationSpace[1] = '2';
                    firstClick = 0;
                }
                else if (sender == _23)
                {
                    destinationSpace[0] = '2';
                    destinationSpace[1] = '3';
                    firstClick = 0;
                }
                else if (sender == _30)
                {
                    destinationSpace[0] = '3';
                    destinationSpace[1] = '0';
                    firstClick = 0;
                }
                else if (sender == _31)
                {
                    destinationSpace[0] = '3';
                    destinationSpace[1] = '1';
                    firstClick = 0;
                }
                else if (sender == _32)
                {
                    destinationSpace[0] = '3';
                    destinationSpace[1] = '2';
                    firstClick = 0;
                }
                else if (sender == _33)
                {
                    destinationSpace[0] = '3';
                    destinationSpace[1] = '3';
                    firstClick = 0;
                }
                else if (sender == _40)
                {
                    destinationSpace[0] = '4';
                    destinationSpace[1] = '0';
                    firstClick = 0;
                }
                else if (sender == _41)
                {
                    destinationSpace[0] = '4';
                    destinationSpace[1] = '1';
                    firstClick = 0;
                }
                else if (sender == _42)
                {
                    destinationSpace[0] = '4';
                    destinationSpace[1] = '2';
                    firstClick = 0;
                }
                else if (sender == _43)
                {
                    destinationSpace[0] = '4';
                    destinationSpace[1] = '3';
                    firstClick = 0;
                }
                else if (sender == _50)
                {
                    destinationSpace[0] = '5';
                    destinationSpace[1] = '0';
                    firstClick = 0;
                }
                else if (sender == _51)
                {
                    destinationSpace[0] = '5';
                    destinationSpace[1] = '1';
                    firstClick = 0;
                }
                else if (sender == _52)
                {
                    destinationSpace[0] = '5';
                    destinationSpace[1] = '2';
                    firstClick = 0;
                }
                else if (sender == _53)
                {
                    destinationSpace[0] = '5';
                    destinationSpace[1] = '3';
                    firstClick = 0;
                }
                else if (sender == _60)
                {
                    destinationSpace[0] = '6';
                    destinationSpace[1] = '0';
                    firstClick = 0;
                }
                else if (sender == _61)
                {
                    destinationSpace[0] = '6';
                    destinationSpace[1] = '1';
                    firstClick = 0;
                }
                else if (sender == _62)
                {
                    destinationSpace[0] = '6';
                    destinationSpace[1] = '2';
                    firstClick = 0;
                }
                else if (sender == _63)
                {
                    destinationSpace[0] = '6';
                    destinationSpace[1] = '3';
                    firstClick = 0;
                }
                else if (sender == _70)
                {
                    destinationSpace[0] = '7';
                    destinationSpace[1] = '0';
                    firstClick = 0;
                }
                else if (sender == _71)
                {
                    destinationSpace[0] = '7';
                    destinationSpace[1] = '1';
                    firstClick = 0;
                }
                else if (sender == _72)
                {
                    destinationSpace[0] = '7';
                    destinationSpace[1] = '2';
                    firstClick = 0;
                }
                else if (sender == _73)
                {
                    destinationSpace[0] = '7';
                    destinationSpace[1] = '3';
                    firstClick = 0;
                }
            }
           
        }

        private bool CanMoveBeMade(char[] Start, char[] End)
        {
            bool result = false;
            if (northPlayersTurn == true)
            {
                int rowStart = (int)Start[0];
                int colStart = (int)Start[1];
                int rowEnd = (int)End[0];
                int colEnd = (int)End[1];

                if (rowStart == 7)
                {
                    result = false;
                }
            }
            else if (northPlayersTurn == false)
            {
                int rowStart = (int)Start[0];
                int colStart = (int)Start[1];
                int rowEnd = (int)End[0];
                int colEnd = (int)End[1];

                if (rowStart == 0)
                {
                    result = false;
                }
            }


            return result;
        }
    }
}
