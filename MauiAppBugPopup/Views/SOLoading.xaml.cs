using CommunityToolkit.Maui.Views;

namespace MauiAppBugPopup.Views;

public partial class SOLoading : Popup
{
    /// <summary>
    /// Inicializa a tela de carregamento
    /// </summary>
    public SOLoading()
    {
        InitializeComponent();
        /*
        if (DeviceInfo.Idiom == DeviceIdiom.Desktop)
            Size = new Size(500, 250);
        else if (DeviceInfo.Idiom == DeviceIdiom.Phone)
            Size = new Size(300, 150);*/
    }

    private void BtnCancel_Clicked(object sender, EventArgs e)
    {
        
    }
    ///<inheritdoc/>
    public void UpdateMessage(string message)
    {
        LblMessage.Text = message;
    }
}