using System.Collections;
using System.Collections.Generic;

namespace LinuxInput
{
    public interface ILinuxInputSimulator
    {
        ILinuxKeyboardSimulator Keyboard { get; }
        ILinuxMouseSimulator Mouse { get; }
    }

    public class LinuxInputSimulator : ILinuxInputSimulator
    {
        private readonly ILinuxKeyboardSimulator _linuxKeyboardSimulator;
        private readonly ILinuxMouseSimulator _linuxMouseSimulator;
        
        public LinuxInputSimulator(ILinuxKeyboardSimulator keyboardSimulator, ILinuxMouseSimulator mouseSimulator)
        {
            _linuxKeyboardSimulator = keyboardSimulator;
            _linuxMouseSimulator = mouseSimulator;
        }
        public LinuxInputSimulator()
        {
            _linuxKeyboardSimulator = new LinuxKeyboardSimulator(this);
            _linuxMouseSimulator = new LinuxMouseSimulator(this);
        }
        public ILinuxKeyboardSimulator Keyboard
        {
            get { return _linuxKeyboardSimulator; }
        }
        public ILinuxMouseSimulator Mouse
        {
            get { return _linuxMouseSimulator; }
        }
    }
}