using System;
using System.ComponentModel;
using System.Collections;

namespace CYQ.Data.Table
{

    /// <summary>
    /// ������Winform���б��󶨡�
    /// </summary>
    [Serializable]
    internal class MDataView : IListSource
    {
        MDataTable table;
        public MDataView(ref MDataTable dt)
        {
            table = dt;
        }
        #region IListSource ��Ա

        public bool ContainsListCollection
        {
            get
            {
                return true;
            }
        }

        public IList GetList()
        {
            return table.Rows;
        }

        #endregion
    }
}