using Avalonia.Controls;
using Avalonia.Interactivity;
using System;

namespace esFigure;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void cmbFigureCambioSelezione(object? sender, SelectionChangedEventArgs e)
    {
        switch (CmbFigure.SelectedIndex)
        {
            case 0:
                TxtLato.IsVisible = true;
                TxtAltezza.IsVisible = false;
                TxtRaggio.IsVisible = false;
                TxtBase.IsVisible = false;
                break;
            case 1:
                TxtLato.IsVisible = false;
                TxtAltezza.IsVisible = true;
                TxtRaggio.IsVisible = false;
                TxtBase.IsVisible = true;
                break;
            case 2:
                TxtLato.IsVisible = false;
                TxtAltezza.IsVisible = false;
                TxtRaggio.IsVisible = true;
                TxtBase.IsVisible = false;
                break;
            default:
                break;
        }
        TxtRisultato.Text = string.Empty;
    }

    private void CalcoloValori(object? sender, RoutedEventArgs e)
    {
        try
        {
            switch (CmbFigure.SelectedIndex)
            {
                case 0:

                    double latoQuadrato;
                    if (!double.TryParse(TxtLato.Text, out latoQuadrato))
                    {
                        throw new ArgumentException("Inserisci un valore numerico valido per il lato del quadrato.");
                    }
                    CQuadrato quadrato = new CQuadrato("Quadrato", latoQuadrato, latoQuadrato);
                    TxtRisultato.Text = quadrato.Descrizione();

                    break;
                case 1:


                    double baseRettangolo, altezzaRettangolo;
                    if (!double.TryParse(TxtBase.Text, out baseRettangolo) || !double.TryParse(TxtAltezza.Text, out altezzaRettangolo))
                    {
                        throw new ArgumentException("Inserisci valori numerici validi per base e altezza.");
                    }
                    CRettangolo rettangolo = new CRettangolo("Rettangolo", baseRettangolo, altezzaRettangolo);
                    TxtRisultato.Text = rettangolo.Descrizione();

                    break;

                case 2:
                    double raggioCerchio;
                    if (!double.TryParse(TxtRaggio.Text, out raggioCerchio))
                    {
                        throw new ArgumentException("Inserisci un valore numerico valido per il raggio.");
                    }
                    CCerchio cerchio = new CCerchio("Cerchio", raggioCerchio);
                    TxtRisultato.Text = cerchio.Descrizione();

                    break;
                default:
                    TxtRisultato.Text = "Seleziona una figura valida.";
                    break;
            }
        }
        catch (ArgumentException ex)
        {
            TxtRisultato.Text = ex.Message;
        }

    }
}