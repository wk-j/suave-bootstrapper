// Required in order to use the addin Cake.Paket because it downloads paket.exe.
#tool nuget:?package=Paket

// Required in order to use PaketRestore, PaketPack, and PaketPush.
#addin nuget:?package=Cake.Paket

Task("Restore").Does(() => {
    PaketRestore();
});

var target = Argument("target", "default");
RunTarget(target);