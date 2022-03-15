using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeCalulator.POC.BusinessLogic.Cureency
{
    public class CurrenncyBL
    {
        public readonly static Decimal[] Notes = { .01m,.02m,.05m,.1m,.2m,.5m,1m,2m, 5m, 10m, 20m, 50m };

        public CurrenncyBL(decimal amount,decimal price)
        {
            var balanceamount = amount - price;

            // Initilize note counts to 0
            this.NoteCount = new int[Notes.Length];

            // Go from lagest note down to smallest
            for (int i = NoteCount.Length - 1; i >= 0; i--)
            {
                // calc count for each note
                NoteCount[i] = (int)(balanceamount / Notes[i]);
                // adjust balance based on notes counted
                balanceamount -= NoteCount[i] * Notes[i];
            }
            // set the remaining moneys
            Remainder = balanceamount;
        }
        public decimal Remainder { get; }
        // Array of count for each note.
        public int[] NoteCount { get; }
        // Total value of notes.
        public decimal NotesValue => Notes.Zip(NoteCount, (note, count) => count * note).Sum();

    }
}
