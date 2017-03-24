

using System;
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;
using SDKTemplate;

namespace SDKTemplate
{
    public partial class MainPage : Page
    {
        public const string FEATURE_NAME = "OCR C# sample";

        List<Scenario> scenarios = new List<Scenario>
        {
            new Scenario() { Title="OCR image file", ClassType=typeof(OcrFileImage)},
            new Scenario() { Title="OCR captured image", ClassType=typeof(OcrCapturedImage)}
        };
    }

    public class Scenario
    {
        public string Title { get; set; }
        public Type ClassType { get; set; }
    }
}
