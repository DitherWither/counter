// So that we don't have to specify which class the constant is in. 
// As all the constants are uppercase, it's easy to tell which are constants and which are not.
global using static io.github.DitherWither.counter.Constants;

using io.github.DitherWither.counter.ui;


var app = Adw.Application.New(APP_ID, Gio.ApplicationFlags.DefaultFlags);
app.OnActivate += (sender, _) => {
    var mainWindow = new MainWindow();

    mainWindow.Application = (Adw.Application) sender;
    mainWindow.Show();
};

return app.Run();
