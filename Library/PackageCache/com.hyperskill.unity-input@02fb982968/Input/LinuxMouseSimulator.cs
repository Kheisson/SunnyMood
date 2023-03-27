namespace LinuxInput
{
    public interface ILinuxMouseSimulator
    {
        ILinuxMouseSimulator MoveMouseBy(int pixelDeltaX, int pixelDeltaY);

        ILinuxMouseSimulator MoveMouseTo(double absoluteX, double absoluteY);

        ILinuxMouseSimulator LeftButtonDown();

        ILinuxMouseSimulator LeftButtonUp();

        ILinuxMouseSimulator LeftButtonClick();

        ILinuxMouseSimulator LeftButtonDoubleClick();

        ILinuxMouseSimulator RightButtonDown();

        ILinuxMouseSimulator RightButtonUp();

        ILinuxMouseSimulator RightButtonClick();

        ILinuxMouseSimulator RightButtonDoubleClick();

        ILinuxMouseSimulator Sleep(int millsecondsTimeout);

		ILinuxMouseSimulator ReleaseAll();
    }

    public class LinuxMouseSimulator : ILinuxMouseSimulator
    {
        private BashShell bashShell;

		private readonly ILinuxInputSimulator _inputSimulator;
        public LinuxMouseSimulator(ILinuxInputSimulator inputSimulator)
        {
            bashShell = new BashShell();
            _inputSimulator = inputSimulator;
        }

        public ILinuxMouseSimulator MoveMouseBy(int pixelDeltaX, int pixelDeltaY)
        {
            bashShell.RunBashCommand("xdotool mousemove_relative " + pixelDeltaX + " " + pixelDeltaY);
            return this;
        }

        public ILinuxMouseSimulator MoveMouseTo(double absoluteX, double absoluteY){
            bashShell.RunBashCommand("xdotool mousemove " + absoluteX + " " + absoluteY);
            return this;
        }

        public ILinuxMouseSimulator LeftButtonDown()
        {
            bashShell.RunBashCommand("xdotool mousedown 1");
            return this;
        }

        public ILinuxMouseSimulator LeftButtonUp()
        {
            bashShell.RunBashCommand("xdotool mouseup 1");
            return this;
        }

        public ILinuxMouseSimulator LeftButtonClick()
        {
            bashShell.RunBashCommand("xdotool click 1");
            return this;
        }

        public ILinuxMouseSimulator LeftButtonDoubleClick()
        {
            bashShell.RunBashCommand("xdotool click --repeat 2 1");
            return this;
        }

        public ILinuxMouseSimulator RightButtonDown()
        {
            bashShell.RunBashCommand("xdotool mousedown 3");
            return this;
        }

        public ILinuxMouseSimulator RightButtonUp()
        {
            bashShell.RunBashCommand("xdotool mouseup 3");
            return this;
        }

        public ILinuxMouseSimulator RightButtonClick()
        {
            bashShell.RunBashCommand("xdotool click 3");
            return this;
        }

        public ILinuxMouseSimulator RightButtonDoubleClick()
        {
            bashShell.RunBashCommand("xdotool click --repeat 2 3");
            return this;
        }

        public ILinuxMouseSimulator Sleep(int millsecondsTimeout)
        {
            bashShell.RunBashCommand("xdotool sleep " + millsecondsTimeout);
            return this;
        }

		public ILinuxMouseSimulator ReleaseAll()
        {
			RightButtonUp();
			LeftButtonUp();
            return this;
        }
    }
}