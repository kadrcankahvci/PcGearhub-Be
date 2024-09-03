using Microsoft.EntityFrameworkCore;
using PcGearHub.Data.DBModels;
using PcGearHub.Repos.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PcGearHub.Repos.Implements
{
    internal class LogHistoryRespository : BaseRepository<LogHistory>, ILogHistoryRepository
    {
        public LogHistoryRespository(DemodbContext context) : base(context)
        {
        }
    }
}
