using StageOneTask.Entity;
using StageOneTask.Interface;

namespace StageOneTask.Interface
{
    public interface ISOTinterface
    {
        SOT GetName(string SlackName);
        SOT GetTrack(string SlackTrack);
        SOT AddTask(SOT task);
    }
}
