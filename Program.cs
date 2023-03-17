using io.github.DitherWither.counter;
using io.github.DitherWither.counter.ui;

var app = Adw.Application.New(Constants.AppId, Gio.ApplicationFlags.DefaultFlags);
app.OnActivate += (sender, _) => {
    var mainWindow = new MainWindow();

    mainWindow.Application = (Adw.Application) sender;
    mainWindow.Show();
};

return app.Run();
