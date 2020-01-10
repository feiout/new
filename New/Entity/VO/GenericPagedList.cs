using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using New.Common;

namespace New.Entity.VO
{
    public class GenericPagedList<T> : NotificationObject
    {

        private ObservableCollection<T> _pagedList;
        public ObservableCollection<T> PagedList
        {
            get { return _pagedList; }
            set
            {
                if (_pagedList != value)
                {
                    _pagedList = value;
                    RaisePropertyChanged("PagedList");
                }
            }
        }
        /// <summary>
        /// Original Source File
        /// </summary>
        private int _totalPages;
        public int totalPages
        {
            get { return _totalPages; }
            set
            {
                if (_totalPages != value)
                {
                    _totalPages = value;
                    RaisePropertyChanged("totalPages");
                }
            }
        }

        /// <summary>
        /// ID
        /// </summary>
        private long _totalElements;
        public long totalElements
        {
            get { return _totalElements; }
            set
            {
                if (_totalElements != value)
                {
                    _totalElements = value;
                    RaisePropertyChanged("totalElements");
                }
            }
        }

        private int _pageSize;
        public int pageSize
        {
            get { return _pageSize; }
            set
            {
                if (_pageSize != value)
                {
                    _pageSize = value;
                    RaisePropertyChanged("pageSize");
                }
            }
        }

        private int _pageNumber;
        public int pageNumber
        {
            get { return _pageNumber; }
            set
            {
                if (_pageNumber != value)
                {
                    _pageNumber = value;
                    RaisePropertyChanged("pageNumber");
                }
            }
        }

    }
}
