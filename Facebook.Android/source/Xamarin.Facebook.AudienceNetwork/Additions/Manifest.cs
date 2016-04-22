﻿using System;
using Android.Runtime;
using Android.App;

namespace Xamarin.Facebook.Ads
{
//    <activity android:name="com.facebook.ads.InterstitialAdActivity"
//        android:configChanges="keyboardHidden|orientation|screenSize" />
    [Register ("com/facebook/ads/InterstitialAdActivity", DoNotGenerateAcw=true)]
    [Activity (Name="com.facebook.ads.InterstitialAdActivity",
        ConfigurationChanges = Android.Content.PM.ConfigChanges.KeyboardHidden | Android.Content.PM.ConfigChanges.Orientation | Android.Content.PM.ConfigChanges.ScreenSize)]
    internal class _InternalInterstitialAdActivity : Activity { }
}
