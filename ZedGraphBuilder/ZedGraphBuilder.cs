using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ZedGraph;
using System.Drawing;

namespace Un_Uncert_modSC
{
    public class ZedGraphBuilder : GraphicBuilder
    {
        /// <summary>
        /// Constructor of the class.
        /// </summary>
        /// <param name="graphControl">Control, which will be use for graphic building</param>
        public ZedGraphBuilder(ZedGraphControl graphControl)
        {
            worksheet = graphControl.GraphPane;
            TypeOfGraphic = GraphicType.LINE;
        }
        /// <summary>
        /// Property set and get a title of diagram
        /// </summary>
        public override string Title
        {
            set 
            {
                worksheet.Title.Text = value;
            }
            get 
            {
                return worksheet.Title.Text;
            }
        }
        /// <summary>
        /// Property set and get a title of x-axis of diagram
        /// </summary>
        public override string XAxisTitle
        {
            set 
            {
                worksheet.XAxis.Title.Text = value;
            }
            get 
            {
                return worksheet.XAxis.Title.Text;
            }
        }
        /// <summary>
        /// Property set and get a title of y-axis of diagram
        /// </summary>
        public override string YAxisTitle
        {
            set
            {
                worksheet.YAxis.Title.Text = value;
            }
            get
            {
                return worksheet.YAxis.Title.Text;
            }
        }
        /// <summary>
        /// Method converts input 2d array of integer, float, double or other numeric types into PointPairsList.
        /// </summary>
        /// <typeparam name="T">All of numeric types</typeparam>
        /// <param name="data">2d array of T-type. Ranks of the array must contain only two values</param>
        /// <exception cref="System.Exception">Thrown when a rank of the array is not contain only two values</exception>
        /// <returns>Return a PointPairList collection</returns>
        private PointPairList prepareData<T>(T[,] data) where T : struct,IComparable, IFormattable, IConvertible, IComparable<T>, IEquatable<T>
        {
            if (data.GetLength(1) != DATA_ARRAY_WIDTH)
                throw new Exception("Data array is not valid. Ranks of array must contain only two values.");

            PointPairList buildData = new PointPairList();

            for (int i = 0; i < data.GetLength(0); i++)
            {
                buildData.Add(Convert.ToDouble(data[i, 0]), Convert.ToDouble(data[i, 1]));
            }

            return buildData;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currentTypeOfGraphic"></param>
        /// <param name="item"></param>
        private void setUpGraphicType(GraphicType currentTypeOfGraphic, CurveItem item)
        {
            switch (currentTypeOfGraphic)
            {
                case GraphicType.LINE: 
                    {
                        LineItem line = item as LineItem;
                        break;
                    } 
                case GraphicType.HISTOGRAM:
                    {
                        BarItem bar = item as BarItem;
                        break;
                    }
                case GraphicType.POINT:
                    {
                        LineItem pointerLine = item as LineItem;
                        pointerLine.Line.IsVisible = false;
                        break;
                    }
                default: throw new Exception("Selected graphic type is not available");
            }
        }
        /// <summary>
        /// Build a graphic of the selected type according to input data
        /// </summary>
        /// <typeparam name="T">All of numeric types</typeparam>
        /// <param name="data">2d array of T-type. Ranks of the array must contain only two values</param>
        public override void buildGraph<T>(T [,] data)
        {
            PointPairList ppl = prepareData(data);
            CurveItem item = null;
            switch (TypeOfGraphic)
            {
                case GraphicType.LINE:
                    {
                        item = worksheet.AddCurve(null, ppl, Color.Black, SymbolType.Triangle);
                        break;
                    }
                case GraphicType.HISTOGRAM:
                    {
                        item = worksheet.AddBar(null, ppl, Color.Red);
                        break;
                    }
                case GraphicType.POINT:
                    {
                        item = worksheet.AddCurve(null, ppl, Color.Black, SymbolType.Triangle);
                        break;
                    }
                default: throw new Exception("Selected graphic type is not available");
            }

            setUpGraphicType(TypeOfGraphic, item);
            worksheet.AxisChange();
        }

        private GraphPane worksheet;
        private const int DATA_ARRAY_WIDTH = 2;


    }
}
