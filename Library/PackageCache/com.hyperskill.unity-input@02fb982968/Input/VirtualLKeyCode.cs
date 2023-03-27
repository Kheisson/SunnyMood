namespace LinuxInput.Native
{
    public enum VirtualLKeyCode
    {
        /// <summary>
        /// Control-break processing
        /// </summary>
        CANCEL = 0xff69,

        /// <summary>
        /// BACKSPACE key
        /// </summary>
        BACK = 0xff08,

        /// <summary>
        /// TAB key
        /// </summary>
        TAB = 0xff09,

        /// <summary>
        /// CLEAR key
        /// </summary>
        CLEAR = 0xff0b,

        /// <summary>
        /// ENTER key
        /// </summary>
        RETURN = 0xff0d,

        /// <summary>
        /// SHIFT key
        /// </summary>
        SHIFT = 0xffe1,

        /// <summary>
        /// CTRL key
        /// </summary>
        CONTROL = 0xffe3,

        /// <summary>
        /// MENU key
        /// </summary>
        MENU = 0xff67,

        /// <summary>
        /// PAUSE key
        /// </summary>
        PAUSE = 0xff13,

        /// <summary>
        /// CAPS LOCK key
        /// </summary>
        CAPITAL = 0xffe5,

        /// <summary>
        /// ESC key
        /// </summary>
        ESCAPE = 0xff1b,

        /// <summary>
        /// SPACEBAR
        /// </summary>
        SPACE = 0x0020,

        /// <summary>
        /// PAGE UP key
        /// </summary>
        PRIOR = 0xff55,

        /// <summary>
        /// PAGE DOWN key
        /// </summary>
        NEXT = 0xff56,

        /// <summary>
        /// END key
        /// </summary>
        END = 0xff57,

        /// <summary>
        /// HOME key
        /// </summary>
        HOME = 0xff50,

        /// <summary>
        /// LEFT ARROW key
        /// </summary>
        LEFT = 0xff51,

        /// <summary>
        /// UP ARROW key
        /// </summary>
        UP = 0xff52,

        /// <summary>
        /// RIGHT ARROW key
        /// </summary>
        RIGHT = 0xff53,

        /// <summary>
        /// DOWN ARROW key
        /// </summary>
        DOWN = 0xff54,

        /// <summary>
        /// SELECT key
        /// </summary>
        SELECT = 0xff60,

        /// <summary>
        /// PRINT key
        /// </summary>
        PRINT = 0xff61,

        /// <summary>
        /// EXECUTE key
        /// </summary>
        EXECUTE = 0xff62,

        /// <summary>
        /// PRINT SCREEN key
        /// </summary>
        SNAPSHOT = 0xff61,

        /// <summary>
        /// INS key
        /// </summary>
        INSERT = 0xff63,

        /// <summary>
        /// DEL key
        /// </summary>
        DELETE = 0xffff,

        /// <summary>
        /// HELP key
        /// </summary>
        HELP = 0xff6a,

        /// <summary>
        /// 0 key
        /// </summary>
        VK_0 = 0x0030,

        /// <summary>
        /// 1 key
        /// </summary>
        VK_1 = 0x0031,

        /// <summary>
        /// 2 key
        /// </summary>
        VK_2 = 0x0032,

        /// <summary>
        /// 3 key
        /// </summary>
        VK_3 = 0x0033,

        /// <summary>
        /// 4 key
        /// </summary>
        VK_4 = 0x0034,

        /// <summary>
        /// 5 key
        /// </summary>
        VK_5 = 0x0035,

        /// <summary>
        /// 6 key
        /// </summary>
        VK_6 = 0x0036,

        /// <summary>
        /// 7 key
        /// </summary>
        VK_7 = 0x0037,

        /// <summary>
        /// 8 key
        /// </summary>
        VK_8 = 0x0038,

        /// <summary>
        /// 9 key
        /// </summary>
        VK_9 = 0x0039,

        /// <summary>
        /// A key
        /// </summary>
        VK_A = 0x0041,

        /// <summary>
        /// B key
        /// </summary>
        VK_B = 0x0042,

        /// <summary>
        /// C key
        /// </summary>
        VK_C = 0x0043,

        /// <summary>
        /// D key
        /// </summary>
        VK_D = 0x0044,

        /// <summary>
        /// E key
        /// </summary>
        VK_E = 0x0045,

        /// <summary>
        /// F key
        /// </summary>
        VK_F = 0x0046,

        /// <summary>
        /// G key
        /// </summary>
        VK_G = 0x0047,

        /// <summary>
        /// H key
        /// </summary>
        VK_H = 0x0048,

        /// <summary>
        /// I key
        /// </summary>
        VK_I = 0x0049,

        /// <summary>
        /// J key
        /// </summary>
        VK_J = 0x004A,

        /// <summary>
        /// K key
        /// </summary>
        VK_K = 0x004B,

        /// <summary>
        /// L key
        /// </summary>
        VK_L = 0x004C,

        /// <summary>
        /// M key
        /// </summary>
        VK_M = 0x004D,

        /// <summary>
        /// N key
        /// </summary>
        VK_N = 0x004E,

        /// <summary>
        /// O key
        /// </summary>
        VK_O = 0x004F,

        /// <summary>
        /// P key
        /// </summary>
        VK_P = 0x0050,

        /// <summary>
        /// Q key
        /// </summary>
        VK_Q = 0x0051,

        /// <summary>
        /// R key
        /// </summary>
        VK_R = 0x0052,

        /// <summary>
        /// S key
        /// </summary>
        VK_S = 0x0053,

        /// <summary>
        /// T key
        /// </summary>
        VK_T = 0x0054,

        /// <summary>
        /// U key
        /// </summary>
        VK_U = 0x0055,

        /// <summary>
        /// V key
        /// </summary>
        VK_V = 0x0056,

        /// <summary>
        /// W key
        /// </summary>
        VK_W = 0x0057,

        /// <summary>
        /// X key
        /// </summary>
        VK_X = 0x0058,

        /// <summary>
        /// Y key
        /// </summary>
        VK_Y = 0x0059,

        /// <summary>
        /// Z key
        /// </summary>
        VK_Z = 0x005A,

        /// <summary>
        /// Left Super key
        /// </summary>
        LSUP = 0xffeb,

        /// <summary>
        /// Right Super key
        /// </summary>
        RSUP = 0xffec,

        /// <summary>
        /// Computer Sleep key
        /// </summary>
        SLEEP = 0x005F,

        /// <summary>
        /// Numeric keypad 0 key
        /// </summary>
        NUMPAD0 = 0xffb0,

        /// <summary>
        /// Numeric keypad 1 key
        /// </summary>
        NUMPAD1 = 0xffb1,

        /// <summary>
        /// Numeric keypad 2 key
        /// </summary>
        NUMPAD2 = 0xffb2,

        /// <summary>
        /// Numeric keypad 3 key
        /// </summary>
        NUMPAD3 = 0xffb3,

        /// <summary>
        /// Numeric keypad 4 key
        /// </summary>
        NUMPAD4 = 0xffb4,

        /// <summary>
        /// Numeric keypad 5 key
        /// </summary>
        NUMPAD5 = 0xffb5,

        /// <summary>
        /// Numeric keypad 6 key
        /// </summary>
        NUMPAD6 = 0xffb6,

        /// <summary>
        /// Numeric keypad 7 key
        /// </summary>
        NUMPAD7 = 0xffb7,

        /// <summary>
        /// Numeric keypad 8 key
        /// </summary>
        NUMPAD8 = 0xffb8,

        /// <summary>
        /// Numeric keypad 9 key
        /// </summary>
        NUMPAD9 = 0xffb9,

        /// <summary>
        /// Multiply key
        /// </summary>
        MULTIPLY = 0xffaa,

        /// <summary>
        /// Add key
        /// </summary>
        ADD = 0xffab,

        /// <summary>
        /// Separator key
        /// </summary>
        SEPARATOR = 0xffac,

        /// <summary>
        /// Subtract key
        /// </summary>
        SUBTRACT = 0xffad,

        /// <summary>
        /// Decimal key
        /// </summary>
        DECIMAL = 0xffae,

        /// <summary>
        /// Divide key
        /// </summary>
        DIVIDE = 0xffaf,

        /// <summary>
        /// F1 key
        /// </summary>
        F1 = 0xffbe,

        /// <summary>
        /// F2 key
        /// </summary>
        F2 = 0xffbf,

        /// <summary>
        /// F3 key
        /// </summary>
        F3 = 0xffc0,

        /// <summary>
        /// F4 key
        /// </summary>
        F4 = 0xffc1,

        /// <summary>
        /// F5 key
        /// </summary>
        F5 = 0xffc2,

        /// <summary>
        /// F6 key
        /// </summary>
        F6 = 0xffc3,

        /// <summary>
        /// F7 key
        /// </summary>
        F7 = 0xffc4,

        /// <summary>
        /// F8 key
        /// </summary>
        F8 = 0xffc5,

        /// <summary>
        /// F9 key
        /// </summary>
        F9 = 0xffc6,

        /// <summary>
        /// F10 key
        /// </summary>
        F10 = 0xffc7,

        /// <summary>
        /// F11 key
        /// </summary>
        F11 = 0xffc8,

        /// <summary>
        /// F12 key
        /// </summary>
        F12 = 0xffc9,

        /// <summary>
        /// F13 key
        /// </summary>
        F13 = 0xffca,

        /// <summary>
        /// F14 key
        /// </summary>
        F14 = 0xffcb,

        /// <summary>
        /// F15 key
        /// </summary>
        F15 = 0xffcc,

        /// <summary>
        /// F16 key
        /// </summary>
        F16 = 0xffcd,

        /// <summary>
        /// F17 key
        /// </summary>
        F17 = 0xffce,

        /// <summary>
        /// F18 key
        /// </summary>
        F18 = 0xffcf,

        /// <summary>
        /// F19 key
        /// </summary>
        F19 = 0xffd0,

        /// <summary>
        /// F20 key
        /// </summary>
        F20 = 0xffd1,

        /// <summary>
        /// F21 key
        /// </summary>
        F21 = 0xffd2,

        /// <summary>
        /// F22 key
        /// </summary>
        F22 = 0xffd3,

        /// <summary>
        /// F23 key
        /// </summary>
        F23 = 0xffd4,

        /// <summary>
        /// F24 key
        /// </summary>
        F24 = 0xffd5,

        /// <summary>
        /// NUM LOCK key
        /// </summary>
        NUMLOCK = 0xff7f,

        /// <summary>
        /// SCROLL LOCK key
        /// </summary>
        SCROLL = 0xff14,

        /// <summary>
        /// Left SHIFT key - Used only as parameters to GetAsyncKeyState() and GetKeyState()
        /// </summary>
        LSHIFT = 0xffe1,

        /// <summary>
        /// Right SHIFT key - Used only as parameters to GetAsyncKeyState() and GetKeyState()
        /// </summary>
        RSHIFT = 0xffe2,

        /// <summary>
        /// Left CONTROL key - Used only as parameters to GetAsyncKeyState() and GetKeyState()
        /// </summary>
        LCONTROL = 0xffe3,

        /// <summary>
        /// Right CONTROL key - Used only as parameters to GetAsyncKeyState() and GetKeyState()
        /// </summary>
        RCONTROL = 0xffe4,

        /// <summary>
        /// Attn key
        /// </summary>
        ATTN = 0xfd0e,

        /// <summary>
        /// CrSel key
        /// </summary>
        CRSEL = 0xfd1c,

        /// <summary>
        /// ExSel key
        /// </summary>
        EXSEL = 0xfd1b,

        /// <summary>
        /// Erase EOF key
        /// </summary>
        EREOF = 0xfd06,

        /// <summary>
        /// Play key
        /// </summary>
        PLAY = 0xfd16,

        /// <summary>
        /// PA1 key
        /// </summary>
        PA1 = 0xfd0a,

        /// <summary>
        /// Clear key
        /// </summary>
        OEM_CLEAR = 0xff0b,
    }
}
