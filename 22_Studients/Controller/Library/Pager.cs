using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controller.Library
{
    public enum Action
    {
        First,
        Previous,
        Next,
        Last
    }
    public class Pager<T>
    {
        
        private List<T> _dataList;
        private Label _label;
        private static int _maxReg, _reg_per_page, _pageCount, _numPage = 1;

        public Pager(List<T> dataList, Label label, int reg_per_page)
        {
            _dataList = dataList;
            _label = label;
            _reg_per_page = reg_per_page;
            _loadData();
        }

        private void _loadData()
        {
            _numPage = 1;
            _maxReg = _dataList.Count;
            _pageCount = _maxReg / _reg_per_page;
            if (_maxReg % _reg_per_page != 0) _pageCount++;
            _label.Text = $"Page 1/ {_pageCount}";
        }

        public int action(Action action)
        {
            switch (action)
            {
                case Action.First:
                    _numPage = 1;
                    break;
                case Action.Last:
                    _numPage = _pageCount;
                    break;
                case Action.Previous:
                    if (_numPage > 1) _numPage--;
                    break;
                case Action.Next:
                    if (_numPage < _pageCount) _numPage++;
                    break;
            }
            _label.Text= $"Page {_numPage}/ {_pageCount}";
            return _numPage;
        }
    }
}
