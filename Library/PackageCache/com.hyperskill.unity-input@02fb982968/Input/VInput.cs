using System;
using System.Runtime.InteropServices;
using WindowsInput;
using WindowsInput.Native;
using LinuxInput;
using LinuxInput.Native;
using UnityEngine;

public static class VInput
{
    private static InputSimulator IS = new InputSimulator();
    private static LinuxInputSimulator ISL = new LinuxInputSimulator();
    private static bool os = RuntimeInformation.IsOSPlatform(OSPlatform.Windows);

    public static void MoveMouseBy(int x, int y)
    {
        if (os) IS.Mouse.MoveMouseBy(x, y);
        else ISL.Mouse.MoveMouseBy(x, y);
    }

    public static void MoveMouseTo(double x, double y)
    {
        if (os) IS.Mouse.MoveMouseTo(x, y);
        else ISL.Mouse.MoveMouseTo(x, y);
    }

    public static void LeftButtonDown()
    {
        if (os) IS.Mouse.LeftButtonDown();
        else ISL.Mouse.LeftButtonDown();
    }

    public static void LeftButtonUp()
    {
        if (os) IS.Mouse.LeftButtonUp();
        else ISL.Mouse.LeftButtonUp();
    }

    public static void LeftButtonClick()
    {
        if (os) IS.Mouse.LeftButtonClick();
        else ISL.Mouse.LeftButtonClick();
    }

    public static void LeftButtonDoubleClick()
    {
        if (os) IS.Mouse.LeftButtonDoubleClick();
        else ISL.Mouse.LeftButtonDoubleClick();
    }

    public static void RightButtonDown()
    {
        if (os) IS.Mouse.RightButtonDown();
        else ISL.Mouse.RightButtonDown();
    }

    public static void RightButtonUp()
    {
        if (os) IS.Mouse.RightButtonUp();
        else ISL.Mouse.RightButtonUp();
    }

    public static void RightButtonClick()
    {
        if (os) IS.Mouse.RightButtonClick();
        else ISL.Mouse.RightButtonClick();
    }

    public static void RightButtonDoubleClick()
    {
        if (os) IS.Mouse.RightButtonDoubleClick();
        else ISL.Mouse.RightButtonDoubleClick();
    }

    public static void TextEntry(string text)
    {
        if (os) IS.Keyboard.TextEntry(text);
        else ISL.Keyboard.TextEntry(text);
    }

    public static void KeyDown(KeyCode key)
    {
        VirtualKeyCode wkc;
        VirtualLKeyCode lkc;
        (wkc,lkc) = DefineKeyCode(key);
        if (os) IS.Keyboard.KeyDown(wkc);
        else ISL.Keyboard.KeyDown(lkc);
    }

    public static void KeyPress(KeyCode key)
    {
        VirtualKeyCode wkc;
        VirtualLKeyCode lkc;
        (wkc,lkc) = DefineKeyCode(key);
        if (os) IS.Keyboard.KeyPress(wkc);
        else ISL.Keyboard.KeyPress(lkc);
    }

    public static void KeyUp(KeyCode key)
    {
        VirtualKeyCode wkc;
        VirtualLKeyCode lkc;
        (wkc,lkc) = DefineKeyCode(key);
        if (os) IS.Keyboard.KeyUp(wkc);
        else ISL.Keyboard.KeyUp(lkc);
    }

	public static void ReleaseAll()
    {
        if (!os){
			ISL.Mouse.ReleaseAll();
			ISL.Keyboard.ReleaseAll();
		}
    }

    private static (VirtualKeyCode, VirtualLKeyCode) DefineKeyCode (KeyCode key)
    {
        switch (key)
        {
            case KeyCode.Backspace: return (VirtualKeyCode.BACK, VirtualLKeyCode.BACK);
            case KeyCode.Tab: return (VirtualKeyCode.TAB, VirtualLKeyCode.TAB);
            case KeyCode.Clear: return (VirtualKeyCode.CLEAR, VirtualLKeyCode.CLEAR);
            case KeyCode.Return: return (VirtualKeyCode.RETURN, VirtualLKeyCode.RETURN);
            case KeyCode.Pause: return (VirtualKeyCode.PAUSE, VirtualLKeyCode.PAUSE);
            case KeyCode.Escape: return (VirtualKeyCode.ESCAPE, VirtualLKeyCode.ESCAPE);
            case KeyCode.Space: return (VirtualKeyCode.SPACE, VirtualLKeyCode.SPACE);
            case KeyCode.Alpha0: return (VirtualKeyCode.VK_0, VirtualLKeyCode.VK_0);
            case KeyCode.Alpha1: return (VirtualKeyCode.VK_1, VirtualLKeyCode.VK_1);
            case KeyCode.Alpha2: return (VirtualKeyCode.VK_2, VirtualLKeyCode.VK_2);
            case KeyCode.Alpha3: return (VirtualKeyCode.VK_3, VirtualLKeyCode.VK_3);
            case KeyCode.Alpha4: return (VirtualKeyCode.VK_4, VirtualLKeyCode.VK_4);
            case KeyCode.Alpha5: return (VirtualKeyCode.VK_5, VirtualLKeyCode.VK_5);
            case KeyCode.Alpha6: return (VirtualKeyCode.VK_6, VirtualLKeyCode.VK_6);
            case KeyCode.Alpha7: return (VirtualKeyCode.VK_7, VirtualLKeyCode.VK_7);
            case KeyCode.Alpha8: return (VirtualKeyCode.VK_8, VirtualLKeyCode.VK_8);
            case KeyCode.Alpha9: return (VirtualKeyCode.VK_9, VirtualLKeyCode.VK_9);
            case KeyCode.A: return (VirtualKeyCode.VK_A, VirtualLKeyCode.VK_A);
            case KeyCode.B: return (VirtualKeyCode.VK_B, VirtualLKeyCode.VK_B);
            case KeyCode.C: return (VirtualKeyCode.VK_C, VirtualLKeyCode.VK_C);
            case KeyCode.D: return (VirtualKeyCode.VK_D, VirtualLKeyCode.VK_D);
            case KeyCode.E: return (VirtualKeyCode.VK_E, VirtualLKeyCode.VK_E);
            case KeyCode.F: return (VirtualKeyCode.VK_F, VirtualLKeyCode.VK_F);
            case KeyCode.G: return (VirtualKeyCode.VK_G, VirtualLKeyCode.VK_G);
            case KeyCode.H: return (VirtualKeyCode.VK_H, VirtualLKeyCode.VK_H);
            case KeyCode.I: return (VirtualKeyCode.VK_I, VirtualLKeyCode.VK_I);
            case KeyCode.J: return (VirtualKeyCode.VK_J, VirtualLKeyCode.VK_J);
            case KeyCode.K: return (VirtualKeyCode.VK_K, VirtualLKeyCode.VK_K);
            case KeyCode.L: return (VirtualKeyCode.VK_L, VirtualLKeyCode.VK_L);
            case KeyCode.M: return (VirtualKeyCode.VK_M, VirtualLKeyCode.VK_M);
            case KeyCode.N: return (VirtualKeyCode.VK_N, VirtualLKeyCode.VK_N);
            case KeyCode.O: return (VirtualKeyCode.VK_O, VirtualLKeyCode.VK_O);
            case KeyCode.P: return (VirtualKeyCode.VK_P, VirtualLKeyCode.VK_P);
            case KeyCode.Q: return (VirtualKeyCode.VK_Q, VirtualLKeyCode.VK_Q);
            case KeyCode.R: return (VirtualKeyCode.VK_R, VirtualLKeyCode.VK_R);
            case KeyCode.S: return (VirtualKeyCode.VK_S, VirtualLKeyCode.VK_S);
            case KeyCode.T: return (VirtualKeyCode.VK_T, VirtualLKeyCode.VK_T);
            case KeyCode.U: return (VirtualKeyCode.VK_U, VirtualLKeyCode.VK_U);
            case KeyCode.V: return (VirtualKeyCode.VK_V, VirtualLKeyCode.VK_V);
            case KeyCode.W: return (VirtualKeyCode.VK_W, VirtualLKeyCode.VK_W);
            case KeyCode.X: return (VirtualKeyCode.VK_X, VirtualLKeyCode.VK_X);
            case KeyCode.Y: return (VirtualKeyCode.VK_Y, VirtualLKeyCode.VK_Y);
            case KeyCode.Z: return (VirtualKeyCode.VK_Z, VirtualLKeyCode.VK_Z);
            case KeyCode.Delete: return (VirtualKeyCode.DELETE, VirtualLKeyCode.DELETE);
            case KeyCode.Keypad0: return (VirtualKeyCode.NUMPAD0, VirtualLKeyCode.NUMPAD0);
            case KeyCode.Keypad1: return (VirtualKeyCode.NUMPAD1, VirtualLKeyCode.NUMPAD1);
            case KeyCode.Keypad2: return (VirtualKeyCode.NUMPAD2, VirtualLKeyCode.NUMPAD2);
            case KeyCode.Keypad3: return (VirtualKeyCode.NUMPAD3, VirtualLKeyCode.NUMPAD3);
            case KeyCode.Keypad4: return (VirtualKeyCode.NUMPAD4, VirtualLKeyCode.NUMPAD4);
            case KeyCode.Keypad5: return (VirtualKeyCode.NUMPAD5, VirtualLKeyCode.NUMPAD5);
            case KeyCode.Keypad6: return (VirtualKeyCode.NUMPAD6, VirtualLKeyCode.NUMPAD6);
            case KeyCode.Keypad7: return (VirtualKeyCode.NUMPAD7, VirtualLKeyCode.NUMPAD7);
            case KeyCode.Keypad8: return (VirtualKeyCode.NUMPAD8, VirtualLKeyCode.NUMPAD8);
            case KeyCode.Keypad9: return (VirtualKeyCode.NUMPAD9, VirtualLKeyCode.NUMPAD9);
            case KeyCode.KeypadPeriod: return (VirtualKeyCode.DECIMAL, VirtualLKeyCode.DECIMAL);
            case KeyCode.KeypadDivide: return (VirtualKeyCode.DIVIDE, VirtualLKeyCode.DIVIDE);
            case KeyCode.KeypadMultiply: return (VirtualKeyCode.MULTIPLY, VirtualLKeyCode.MULTIPLY);
            case KeyCode.KeypadMinus: return (VirtualKeyCode.SUBTRACT, VirtualLKeyCode.SUBTRACT);
            case KeyCode.KeypadPlus: return (VirtualKeyCode.ADD, VirtualLKeyCode.ADD);
            case KeyCode.KeypadEnter: return (VirtualKeyCode.RETURN, VirtualLKeyCode.RETURN);
            case KeyCode.UpArrow: return (VirtualKeyCode.UP, VirtualLKeyCode.UP);
            case KeyCode.DownArrow: return (VirtualKeyCode.DOWN, VirtualLKeyCode.DOWN);
            case KeyCode.RightArrow: return (VirtualKeyCode.RIGHT, VirtualLKeyCode.RIGHT);
            case KeyCode.LeftArrow: return (VirtualKeyCode.LEFT, VirtualLKeyCode.LEFT);
            case KeyCode.Insert: return (VirtualKeyCode.INSERT, VirtualLKeyCode.INSERT);
            case KeyCode.Home: return (VirtualKeyCode.HOME, VirtualLKeyCode.HOME);
            case KeyCode.End: return (VirtualKeyCode.END, VirtualLKeyCode.END);
            case KeyCode.PageUp: return (VirtualKeyCode.PRIOR, VirtualLKeyCode.PRIOR);
            case KeyCode.PageDown: return (VirtualKeyCode.NEXT, VirtualLKeyCode.NEXT);
            case KeyCode.F1: return (VirtualKeyCode.F1, VirtualLKeyCode.F1);
            case KeyCode.F2: return (VirtualKeyCode.F2, VirtualLKeyCode.F2);
            case KeyCode.F3: return (VirtualKeyCode.F3, VirtualLKeyCode.F3);
            case KeyCode.F4: return (VirtualKeyCode.F4, VirtualLKeyCode.F4);
            case KeyCode.F5: return (VirtualKeyCode.F5, VirtualLKeyCode.F5);
            case KeyCode.F6: return (VirtualKeyCode.F6, VirtualLKeyCode.F6);
            case KeyCode.F7: return (VirtualKeyCode.F7, VirtualLKeyCode.F7);
            case KeyCode.F8: return (VirtualKeyCode.F8, VirtualLKeyCode.F8);
            case KeyCode.F9: return (VirtualKeyCode.F9, VirtualLKeyCode.F9);
            case KeyCode.F10: return (VirtualKeyCode.F10, VirtualLKeyCode.F10);
            case KeyCode.F11: return (VirtualKeyCode.F11, VirtualLKeyCode.F11);
            case KeyCode.F12: return (VirtualKeyCode.F12, VirtualLKeyCode.F12);
            case KeyCode.F13: return (VirtualKeyCode.F13, VirtualLKeyCode.F13);
            case KeyCode.F14: return (VirtualKeyCode.F14, VirtualLKeyCode.F14);
            case KeyCode.F15: return (VirtualKeyCode.F15, VirtualLKeyCode.F15);
            case KeyCode.Numlock: return (VirtualKeyCode.NUMLOCK, VirtualLKeyCode.NUMLOCK);
            case KeyCode.CapsLock: return (VirtualKeyCode.CAPITAL, VirtualLKeyCode.CAPITAL);
            case KeyCode.ScrollLock: return (VirtualKeyCode.SCROLL, VirtualLKeyCode.SCROLL);
            case KeyCode.RightShift: return (VirtualKeyCode.RSHIFT, VirtualLKeyCode.RSHIFT);
            case KeyCode.LeftShift: return (VirtualKeyCode.LSHIFT, VirtualLKeyCode.LSHIFT);
            case KeyCode.RightControl: return (VirtualKeyCode.RCONTROL, VirtualLKeyCode.RCONTROL);
            case KeyCode.LeftControl: return (VirtualKeyCode.LCONTROL, VirtualLKeyCode.LCONTROL);
            case KeyCode.RightAlt: return (VirtualKeyCode.RMENU, VirtualLKeyCode.MENU);
            case KeyCode.LeftAlt: return (VirtualKeyCode.LMENU, VirtualLKeyCode.MENU);
            case KeyCode.AltGr: return (VirtualKeyCode.RMENU, VirtualLKeyCode.MENU);
            case KeyCode.Help: return (VirtualKeyCode.HELP, VirtualLKeyCode.HELP);
            case KeyCode.Print: return (VirtualKeyCode.PRINT, VirtualLKeyCode.PRINT);
            case KeyCode.SysReq: return (VirtualKeyCode.PRINT, VirtualLKeyCode.PRINT);
            case KeyCode.Break: return (VirtualKeyCode.PAUSE, VirtualLKeyCode.PAUSE);
            case KeyCode.Menu: return (VirtualKeyCode.MENU, VirtualLKeyCode.MENU);
        }
        throw new Exception("KeyCode not found!");
    }
}