using System.Runtime.InteropServices;

namespace Wox.Plugin.SteamTable.IFC97
{
    public static class IFC97Wrapper
    {
        #region P
        [DllImport("UEwasp64")]
        public static extern void P2T97(double p, ref double t, ref int r);

        [DllImport("UEwasp64")]
        public static extern void P2HL97(double p, ref double h, ref int r);

        [DllImport("UEwasp64")]
        public static extern void P2HG97(double p, ref double h, ref int r);

        [DllImport("UEwasp64")]
        public static extern void P2SL97(double p, ref double h, ref int r);

        [DllImport("UEwasp64")]
        public static extern void P2SG97(double p, ref double h, ref int r);

        [DllImport("UEwasp64")]
        public static extern void P2VL97(double p, ref double v, ref int r);

        [DllImport("UEwasp64")]
        public static extern void P2VG97(double p, ref double v, ref int r);

        [DllImport("UEwasp64")]
        public static extern void P2KSG97(double p, ref double ks, ref int r);

        [DllImport("UEwasp64")]
        public static extern void P2KSL97(double p, ref double ks, ref int r);

        [DllImport("UEwasp64")]
        public static extern void P2ETAL97(double p, ref double h, ref int r);

        [DllImport("UEwasp64")]
        public static extern void P2ETAG97(double p, ref double h, ref int r);
        #endregion

        #region T
        [DllImport("UEwasp64")]
        public static extern void T2P97(double t, ref double p, ref int r);

        [DllImport("UEwasp64")]
        public static extern void T2VL97(double p, ref double v, ref int r);

        [DllImport("UEwasp64")]
        public static extern void T2VG97(double p, ref double v, ref int r);

        [DllImport("UEwasp64")]
        public static extern void T2HL97(double p, ref double h, ref int r);

        [DllImport("UEwasp64")]
        public static extern void T2HG97(double p, ref double h, ref int r);

        [DllImport("UEwasp64")]
        public static extern void T2SG97(double p, ref double s, ref int r);

        [DllImport("UEwasp64")]
        public static extern void T2SL97(double p, ref double s, ref int r);

        [DllImport("UEwasp64")]
        public static extern void T2KSG97(double p, ref double ks, ref int r);

        [DllImport("UEwasp64")]
        public static extern void T2KSL97(double p, ref double ks, ref int r);

        [DllImport("UEwasp64")]
        public static extern void T2ETAL97(double p, ref double h, ref int r);

        [DllImport("UEwasp64")]
        public static extern void T2ETAG97(double p, ref double h, ref int r);

        #endregion

        #region PT
        [DllImport("UEwasp64")]
        public static extern void PT2H97(double p, double t, ref double h, ref int r);

        [DllImport("UEwasp64")]
        public static extern void PT2S97(double p, double t, ref double ks, ref int r);

        [DllImport("UEwasp64")]
        public static extern void PT2V97(double p, double t, ref double v, ref int r);

        [DllImport("UEwasp64")]
        public static extern void PT2ETA97(double p, double t, ref double cp, ref int r);

        [DllImport("UEwasp64")]
        public static extern void PT2KS97(double p, double t, ref double ks, ref int r);
        #endregion
    }
}
