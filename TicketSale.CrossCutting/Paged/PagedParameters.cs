namespace TicketSale.Data.Paged
{
    public class PagedParameters
    {
        public int PagedSizeMax { get; set; } = 50;
        public int NumberPage { get; set; } = 1;
        public int _PagedSize { get; private set; } = 10;
        public int PagedSize
        {
            get
            {
                return _PagedSize;
            }
            set
            {
                this._PagedSize = (value > this.PagedSizeMax ? PagedSizeMax : value);
            }
        }
    }
    }
