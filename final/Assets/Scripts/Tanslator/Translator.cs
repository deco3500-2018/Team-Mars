using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using IBM.Watson.DeveloperCloud.Services.LanguageTranslator.v3;
using IBM.Watson.DeveloperCloud.Logging;
using IBM.Watson.DeveloperCloud.Utilities;
using IBM.Watson.DeveloperCloud.DataTypes;
using IBM.Watson.DeveloperCloud.Connection;

public class Translator : MonoBehaviour {
	#region PLEASE SET THESE VARIABLES IN THE INSPECTOR
	[Space(10)]
	[Tooltip("The service URL (optional). This defaults to \"https://stream.watsonplatform.net/speech-to-text/api\"")]
	[SerializeField]
	private string _serviceUrl;
	[Tooltip("Text field to display the results of streaming.")]
	public Text ResultsField;
	[Header("CF Authentication")]
	[Tooltip("The authentication username.")]
	[SerializeField]
	private string _username;
	[Tooltip("The authentication password.")]
	[SerializeField]
	private string _password;
	[Header("IAM Authentication")]
	[Tooltip("The IAM apikey.")]
	[SerializeField]
	private string _iamApikey;
	[Tooltip("The IAM url used to authenticate the apikey (optional). This defaults to \"https://iam.bluemix.net/identity/token\".")]
	[SerializeField]
	private string _iamUrl;
	#endregion

	public Text ResponseTextField;

	private LanguageTranslator _languageTranslator;
	private string _translationModel = "en-zh";

	// Use this for initialization
	void Start () {
		LogSystem.InstallDefaultReactors ();
		Runnable.Run(CreateService());
	}

	private IEnumerator CreateService()
	{
		//  Create credential and instantiate service
		Credentials credentials = null;
		if (!string.IsNullOrEmpty(_username) && !string.IsNullOrEmpty(_password))
		{
			//  Authenticate using username and password
			credentials = new Credentials(_username, _password, _serviceUrl);
		}
		else if (!string.IsNullOrEmpty(_iamApikey))
		{
			//  Authenticate using iamApikey

			TokenOptions tokenOptions = new TokenOptions()
			{
				IamApiKey = _iamApikey,
				IamUrl = _iamUrl
			};

			credentials = new Credentials(tokenOptions, _serviceUrl);

			//  Wait for tokendata
			while (!credentials.HasIamTokenData())
				yield return null;

			//Debug.Log("fk");
		}
		else
		{
			throw new WatsonException("Please provide either username and password or IAM apikey to authenticate the service.");
		}

		_languageTranslator = new LanguageTranslator ("2018-05-01", credentials);

		//Translate ("Where is the library?");
	}

	public void	Translate(string text){
		_languageTranslator.GetTranslation(OnTranslate, OnFail, text, _translationModel);
	}

	private void OnTranslate(Translations response, Dictionary<string, object> customData){
		ResponseTextField.text = response.translations[0].translation;
	}

	private void OnFail(RESTConnector.Error error,  Dictionary<string, object> customData){
		Log.Debug ("Translator.OnFail()", "Error:{0}", error.ToString ());

	}

}
