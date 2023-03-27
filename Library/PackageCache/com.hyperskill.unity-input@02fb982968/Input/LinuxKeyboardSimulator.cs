using System;
using System.Diagnostics;
using System.Collections.Generic;
using LinuxInput.Native;
using UnityEngine;

namespace LinuxInput
{
    public interface ILinuxKeyboardSimulator
    {
        ILinuxKeyboardSimulator KeyDown(VirtualLKeyCode keyCode);
        ILinuxKeyboardSimulator KeyPress(VirtualLKeyCode keyCode);
        ILinuxKeyboardSimulator KeyUp(VirtualLKeyCode keyCode);
        ILinuxKeyboardSimulator TextEntry(string text);
        
        ILinuxKeyboardSimulator Sleep(int millsecondsTimeout);
		ILinuxKeyboardSimulator ReleaseAll();
    }

    public class LinuxKeyboardSimulator : ILinuxKeyboardSimulator
    {
        private BashShell bashShell;
		private Dictionary<VirtualLKeyCode, bool> keys = new Dictionary<VirtualLKeyCode, bool>(); 
        private readonly ILinuxInputSimulator _inputSimulator;
        
        public LinuxKeyboardSimulator(ILinuxInputSimulator inputSimulator)
        {
            bashShell = new BashShell();
            _inputSimulator = inputSimulator;
        }
        public ILinuxKeyboardSimulator KeyDown(VirtualLKeyCode keyCode)
        {
			if(!keys.ContainsKey(keyCode)){
				keys.Add(keyCode, true);
			}else{
				keys[keyCode] = true;
			}
            bashShell.RunBashCommand("xdotool keydown " + $"0x{keyCode:x}");
            return this;
        }
        public ILinuxKeyboardSimulator KeyPress(VirtualLKeyCode keyCode)
        {
            bashShell.RunBashCommand("xdotool key " + $"0x{keyCode:x}");
            return this;
        }
        public ILinuxKeyboardSimulator KeyUp(VirtualLKeyCode keyCode)
        {
			if(keys.ContainsKey(keyCode)){
				keys[keyCode] = false;
			}
            bashShell.RunBashCommand("xdotool keyup " + $"0x{keyCode:x}");
            return this;
        }
        public ILinuxKeyboardSimulator TextEntry(string text)
        {
            bashShell.RunBashCommand("xdotool type " + text);
            return this;
        }

        public ILinuxKeyboardSimulator Sleep(int millsecondsTimeout)
        {
            bashShell.RunBashCommand("xdotool sleep " + millsecondsTimeout);
            return this;
        }
		public ILinuxKeyboardSimulator ReleaseAll()
        {
			Dictionary<VirtualLKeyCode, bool> copyKeys = new Dictionary<VirtualLKeyCode, bool>(keys);
			foreach( KeyValuePair<VirtualLKeyCode, bool> kvp in copyKeys )
			{
    			if(kvp.Value)
					KeyUp(kvp.Key);
			}
            return this;
        }
    }
}