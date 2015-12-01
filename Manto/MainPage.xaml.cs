using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
using Windows.Media.SpeechSynthesis;
using MantoLib;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Manto
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public List<FortuneInformation> fortuneInformationList;
        public MainPage()
        {
            this.InitializeComponent();
        }

        private async void Fortune_Text_Click(object sender, TappedRoutedEventArgs e)
        {
            MediaElement media = new MediaElement();
            string text = textBlockFortune.Text;
            SpeechSynthesizer synthesizer = new SpeechSynthesizer();
            SpeechSynthesisStream stream = await synthesizer.SynthesizeTextToStreamAsync(text + ", God bless America");
            media.SetSource(stream, stream.ContentType);
            media.IsLooping = true;
            media.Play();
        }

        private void randomNewFortune(object sender, TappedRoutedEventArgs e)
        {
            randomFortune(fortuneInformationList);
        }

        public string randomFortune(List<FortuneInformation> items)
        {
            if (items.Count == 1)
            {
                return items.First().Name + " will die in a fire tomorrow!";
            }
            else if (items.Count == 2)
            {
                return items.First().Name + " will ask " + items[1].Name + " about their day and not be interested at all!";
            }
            else
            {
                return "Undefined";
            }
        }


        }


}
