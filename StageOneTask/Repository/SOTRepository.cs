
using StageOneTask.Data;
using StageOneTask.Entity;
using StageOneTask.Interface;

namespace StageOneTask.Repository
{
    public class SOTRepository : ISOTinterface
    {
        private readonly SOTContext _context;

        public SOTRepository(SOTContext context)
        {
            _context=context;
        }

        public SOT AddTask(SOT task)
        {
            _context.Task.Add(task);
            _context.SaveChanges();
            return task;
        }

        public SOT GetName(string SlackName)
        {
            var user = _context.Task.Where(c => c.SlackName == SlackName).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("Name not Found");
            }
            return user;
        }

        public SOT GetTrack(string SlackTrack)
        {
            var user = _context.Task.Where(k => k.Track==SlackTrack).FirstOrDefault();
            if (user == null)
            {
                throw new Exception("Track not Found");
            }
            return user;
        }
    }
}
