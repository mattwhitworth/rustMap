namespace Oxide.Plugins
{
    [ Info( "RustExample", "ted.lua", "0.0.1" ) ]
    public class ClassLibary3 : RustPlugin
    {
        void Init()
        {
            Puts("RustExample Plugin has loaded.");
        }
    }
}
