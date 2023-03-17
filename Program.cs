// TODO replace io.github.ditherwither.blueprint-template with your app's ID
const string APP_ID = "io.github.ditherwither.counter";

var app = Adw.Application.New(APP_ID, Gio.ApplicationFlags.DefaultFlags);
app.OnActivate += (sender, args) => {
    var mainWindow = new ui.MainWindow();

    mainWindow.Application = (Adw.Application) sender;
    mainWindow.Show();
};

return app.Run();
