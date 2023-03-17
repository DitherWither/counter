namespace io.github.DitherWither.counter.ui;

// TODO: Remove the warning suppression when the gtksharp bindings are updated

public class MainWindow : Adw.ApplicationWindow
{
    // References to widgets in the UI file
    // Disabling the warnings here because these fields should be initialized by gtk
#pragma warning disable CS0649
    [Gtk.Connect] private Gtk.Button _incrementButton;
    [Gtk.Connect] private Gtk.Button _decrementButton;
    [Gtk.Connect] private Gtk.Button _resetButton;

    [Gtk.Connect] private Gtk.Label _counterLabel;
#pragma warning restore CS0649

    private int _counter;

    // Once again, the warning about uninitialized variables is suppressed because they should be initialized by gtk
#pragma warning disable CS8618
    private MainWindow(Gtk.Builder builder, string name) : base(builder.GetPointer(name), false)
#pragma warning restore CS8618
    {
        builder.Connect(this);

        // Set up the buttons.
        // The warning is disabled because the buttons are initialized in the UI file, so they should never be null
#pragma warning disable CS8602
        _incrementButton.OnClicked += (_, _) => IncrementCounter();
        _decrementButton.OnClicked += (_, _) => DecrementCounter();
        _resetButton.OnClicked += (_, _) => ResetCounter();
#pragma warning restore CS8602
    }

    private void IncrementCounter()
    {
        _counter++;
        UpdateCounter();
    }

    private void DecrementCounter()
    {
        _counter--;
        UpdateCounter();
    }

    private void ResetCounter()
    {
        _counter = 0;
        UpdateCounter();
    }


    /// <summary>
    /// Updates the counter label to the current value of the counter.
    /// </summary>
    private void UpdateCounter()
    {
        _counterLabel.SetLabel(_counter.ToString());
    }

    // This is empty because we are just calling the other constructor
    public MainWindow() : this(new Gtk.Builder("MainWindow.ui"), "main_window")
    {

    }
}
