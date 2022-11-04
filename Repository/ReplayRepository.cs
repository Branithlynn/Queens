using Queens.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Queens.Repository
{
    class ReplayRepository
    {
        public int GetNextId(List<ReplayMoves> moves)
        {
            int id = 0;
            foreach (var item in moves)
            {
                id++;
            }
            return id;
        }
    }
}
