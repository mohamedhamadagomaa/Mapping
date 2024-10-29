using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace TableValuedFunction.Entities
{
    [NotMapped]
    public class Snapshot
    {

        public DateTime LoadAt => DateTime.Now;
        public String Versoin => Guid.NewGuid().ToString().Substring(0, 8);
    }
}
