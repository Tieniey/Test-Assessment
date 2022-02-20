using Microsoft.AspNetCore.Components;
using _2C2PTest.Models;

namespace Transaction2C2PBase
{
    public class Transaction2C2PBase : ComponentBase
    {
        public Transaction2C2p Transaction2C2p
        {
            get;
            set;
        }

        protected override Task OnInitializedAsync()
        {
            Transaction2C2p = new Transaction2C2p();
            return base.OnInitializedAsync();
        }
    }
}
