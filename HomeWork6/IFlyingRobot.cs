namespace HomeWork6
{
    internal interface IFlyingRobot : IRobot
    {
        public new string GetRobotType() => "I am a flying robot.";
    }
}
