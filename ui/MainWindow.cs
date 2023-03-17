namespace ui;

public class MainWindow : Adw.ApplicationWindow
{
    private MainWindow(Gtk.Builder builder, string name) : base(builder.GetPointer(name), false)
    {
        builder.Connect(this);
    }

    public MainWindow() : this(new Gtk.Builder("MainWindow.ui"), "main_window")
    {

    }
}
