using System;
using Xamarin.Forms;
using XamarinFormsClase08_Demo.Droid;
using Android.Speech.Tts;
using Java.Util;
using System.Collections.Generic;
using Android.Runtime;
using System.Linq;

[assembly: Dependency(typeof(TextoASonido))]
namespace XamarinFormsClase08_Demo.Droid
{
	public class TextoASonido : Java.Lang.Object,iTextoASonido, TextToSpeech.IOnInitListener
	{
		TextToSpeech speaker;
		string toSpeak;

		public void OnInit ([GeneratedEnum] OperationResult status)
		{
			if (status.Equals (OperationResult.Success)) {
            var p = new Dictionary<string, string> ();

				speaker.SetLanguage (Locale.French);
				speaker.Speak (toSpeak, QueueMode.Flush, p);
        	}	
		}

		public void Speak (string text)
		{
			var ctx = Forms.Context;
			toSpeak = text;
			if (speaker == null) {
				speaker = new TextToSpeech (ctx, this);
			} else {
				var p = new Dictionary<string, string> ();
				speaker.SetLanguage (Locale.ForLanguageTag("it"));
				//speaker.SetVoice(Voice.
				speaker.Speak (toSpeak, QueueMode.Flush, p);
			}

	var voices = speaker.Voices;
//speaker.SetVoice (new Voice (voices.FirstOrDefault().Name, Locale.French, VoiceQuality.High, VoiceLatency.Normal, false, nu);
			
		}
	}
}
