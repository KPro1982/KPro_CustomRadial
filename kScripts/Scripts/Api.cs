namespace kScripts
{
  public class Api :IModApi
    {
      public void InitMod()
      {
      ModEvents.GameStartDone.RegisterHandler(GameStartDoneHandler);
    }

      private void GameStartDoneHandler()
      {
        //do stuff
      }
    }
}
