using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace srevels2c1
{
    public partial class Form1 : Form
    {
       private byte byte1, byte2, byte3;
       private sbyte sbyte1, sbyte2, sbyte3;
       private short short1, short2, short3;
       private ushort ushort1, ushort2, ushort3;
       private int int1, int2, int3;
       private uint uint1, uint2, uint3;
       private long long1, long2, long3;
       private ulong ulong1, ulong2, ulong3;
       private float float1, float2, float3;
       private double double1, double2, double3;
       private decimal decimal1, decimal2, decimal3;

        private void BtnSub_Click(object sender, EventArgs e)
        {
            this.byte3 = Convert.ToByte(this.byte1 - this.byte2);
            ByteTB3.Text = Convert.ToString(byte3);

            this.sbyte3 = Convert.ToSByte(this.sbyte1 - this.sbyte2);
            SByteTB3.Text = Convert.ToString(sbyte3);

            this.short3 = Convert.ToInt16(this.short1 - this.short2);
            ShortTB3.Text = Convert.ToString(short3);

            this.ushort3 = Convert.ToUInt16(this.ushort1 - this.ushort2);
            UShortTB3.Text = Convert.ToString(ushort3);

            this.int3 = Convert.ToInt32(this.int1 - this.int2);
            IntTB3.Text = Convert.ToString(int3);

            this.uint3 = Convert.ToUInt32(this.uint1 - this.uint2);
            UIntTB3.Text = Convert.ToString(uint3);

            this.long3 = Convert.ToInt64(this.long1 - this.long2);
            LongTB3.Text = Convert.ToString(long3);

            this.ulong3 = Convert.ToUInt64(this.ulong1 - this.ulong2);
            ULongTB3.Text = Convert.ToString(ulong3);

            this.float3 = Convert.ToSingle(this.float1 - this.float2);
            FloatTB3.Text = Convert.ToString(float3);

            this.double3 = Convert.ToDouble(this.double1 - this.double2);
            DoubleTB3.Text = Convert.ToString(double3);

            this.decimal3 = Convert.ToDecimal(this.decimal1 - this.decimal2);
            DecimalTB3.Text = Convert.ToString(decimal3);

        }

        private void BtnMulti_Click(object sender, EventArgs e)
        {
            this.byte3 = Convert.ToByte(this.byte1 * this.byte2);
            ByteTB3.Text = Convert.ToString(byte3);

            this.sbyte3 = Convert.ToSByte(this.sbyte1 * this.sbyte2);
            SByteTB3.Text = Convert.ToString(sbyte3);

            this.short3 = Convert.ToInt16(this.short1 * this.short2);
            ShortTB3.Text = Convert.ToString(short3);

            this.ushort3 = Convert.ToUInt16(this.ushort1 * this.ushort2);
            UShortTB3.Text = Convert.ToString(ushort3);

            this.int3 = Convert.ToInt32(this.int1 * this.int2);
            IntTB3.Text = Convert.ToString(int3);

            this.uint3 = Convert.ToUInt32(this.uint1 * this.uint2);
            UIntTB3.Text = Convert.ToString(uint3);

            this.long3 = Convert.ToInt64(this.long1 * this.long2);
            LongTB3.Text = Convert.ToString(long3);

            this.ulong3 = Convert.ToUInt64(this.ulong1 * this.ulong2);
            ULongTB3.Text = Convert.ToString(ulong3);

            this.float3 = Convert.ToSingle(this.float1 * this.float2);
            FloatTB3.Text = Convert.ToString(float3);

            this.double3 = Convert.ToDouble(this.double1 * this.double2);
            DoubleTB3.Text = Convert.ToString(double3);

            this.decimal3 = Convert.ToDecimal(this.decimal1 * this.decimal2);
            DecimalTB3.Text = Convert.ToString(decimal3);
        }

        private void BtnDivi_Click(object sender, EventArgs e)
        {
            this.byte3 = Convert.ToByte(this.byte1 / this.byte2);
            ByteTB3.Text = Convert.ToString(byte3);

            this.sbyte3 = Convert.ToSByte(this.sbyte1 / this.sbyte2);
            SByteTB3.Text = Convert.ToString(sbyte3);

            this.short3 = Convert.ToInt16(this.short1 / this.short2);
            ShortTB3.Text = Convert.ToString(short3);

            this.ushort3 = Convert.ToUInt16(this.ushort1 / this.ushort2);
            UShortTB3.Text = Convert.ToString(ushort3);

            this.int3 = Convert.ToInt32(this.int1 / this.int2);
            IntTB3.Text = Convert.ToString(int3);

            this.uint3 = Convert.ToUInt32(this.uint1 / this.uint2);
            UIntTB3.Text = Convert.ToString(uint3);

            this.long3 = Convert.ToInt64(this.long1 / this.long2);
            LongTB3.Text = Convert.ToString(long3);

            this.ulong3 = Convert.ToUInt64(this.ulong1 / this.ulong2);
            ULongTB3.Text = Convert.ToString(ulong3);

            this.float3 = Convert.ToSingle(this.float1 / this.float2);
            FloatTB3.Text = Convert.ToString(float3);

            this.double3 = Convert.ToDouble(this.double1 / this.double2);
            DoubleTB3.Text = Convert.ToString(double3);

            this.decimal3 = Convert.ToDecimal(this.decimal1 / this.decimal2);
            DecimalTB3.Text = Convert.ToString(decimal3);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
           this.byte3 = Convert.ToByte(this.byte1 + this.byte2);
            ByteTB3.Text = Convert.ToString(byte3);

            this.sbyte3 = Convert.ToSByte(this.sbyte1 + this.sbyte2);
            SByteTB3.Text = Convert.ToString(sbyte3);

            this.short3 = Convert.ToInt16(this.short1 + this.short2);
            ShortTB3.Text = Convert.ToString(short3);

            this.ushort3 = Convert.ToUInt16(this.ushort1 + this.ushort2);
            UShortTB3.Text = Convert.ToString(ushort3);

            this.int3 = checked(this.int1 + this.int2);
            IntTB3.Text = Convert.ToString(int3);

            this.uint3 = Convert.ToUInt32(this.uint1 + this.uint2);
            UIntTB3.Text = Convert.ToString(uint3);

            this.long3 = Convert.ToInt64(this.long1 + this.long2);
            LongTB3.Text = Convert.ToString(long3);

            this.ulong3 = Convert.ToUInt64(this.ulong1 + this.ulong2);
            ULongTB3.Text = Convert.ToString(ulong3);

            this.float3 = Convert.ToSingle(this.float1 + this.float2);
            FloatTB3.Text = Convert.ToString(float3);

            this.double3 = Convert.ToDouble(this.double1 + this.double2);
            DoubleTB3.Text = Convert.ToString(double3);

            this.decimal3 = Convert.ToDecimal(this.decimal1 + this.decimal2);
            DecimalTB3.Text = Convert.ToString(decimal3);
        }



       private void Input2TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte2 = Convert.ToByte(input2textbox.Text);
                ByteTB2.Text = byte2.ToString();
            }
            catch (Exception) { ByteTB2.Text = "error"; byte2 = 0; }
            try
            {
                sbyte2 = Convert.ToSByte(input2textbox.Text);
                SByteTB2.Text = sbyte2.ToString();
            }
            catch (Exception) { SByteTB2.Text = "error"; sbyte2 = 0; }
            try
            {
                short2 = Convert.ToInt16(input2textbox.Text);
                ShortTB2.Text = short2.ToString();
            }
            catch (Exception) { ShortTB2.Text = "error"; short2 = 0; }
            try
            {
                ushort2 = Convert.ToUInt16(input2textbox.Text);
                UShortTB2.Text = ushort2.ToString();
            }
            catch (Exception) { UShortTB2.Text = "error"; ushort2 = 0; }
            try
            {
                int2 = Convert.ToInt32(input2textbox.Text);
                IntTB2.Text = int2.ToString();
            }
            catch (Exception) { IntTB2.Text = "error"; int2 = 0; }
            try
            {
                uint2 = Convert.ToUInt32(input2textbox.Text);
                UIntTB2.Text = uint2.ToString();
            }
            catch (Exception) { UIntTB2.Text = "error"; uint2 = 0; }
            try
            {
                long2 = Convert.ToInt64(input2textbox.Text);
                LongTB2.Text = long2.ToString();
            }
            catch (Exception) { LongTB2.Text = "error"; long2 = 0; }
            try
            {
                ulong2 = Convert.ToUInt64(input2textbox.Text);
                ULongTB2.Text = ulong2.ToString();
            }
            catch (Exception) { ULongTB2.Text = "error"; ulong2 = 0; }
            try
            {
                float2 = Convert.ToSingle(input2textbox.Text);
                FloatTB2.Text = float2.ToString();
            }
            catch (Exception) { FloatTB2.Text = "error"; float2 = 0.0f; }
            try
            {
                double2 = Convert.ToDouble(input2textbox.Text);
                DoubleTB2.Text = double2.ToString();
            }
            catch (Exception) { DoubleTB2.Text = "error"; double2 = 0.0; }
            try
            {
                decimal2 = Convert.ToDecimal(input2textbox.Text);
                DecimalTB2.Text = decimal2.ToString();
            }
            catch (Exception) { DecimalTB2.Text = "error"; decimal2 = 0.0m; }
          
        }



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnMinimum_Click(object sender, EventArgs e)
        {

            byte1 = byte.MinValue; ByteTB1.Text = Convert.ToString(byte1);
            sbyte1 = sbyte.MinValue; SByteTB1.Text = Convert.ToString(sbyte1);
            short1 = short.MinValue; ShortTB1.Text = Convert.ToString(short1);
            ushort1 = ushort.MinValue; UShortTB1.Text = Convert.ToString(ushort1);
            int1 = int.MinValue; IntTB1.Text = Convert.ToString(int1);
            uint1 = uint.MinValue; UIntTB1.Text = Convert.ToString(uint1);
            long1 = long.MinValue; LongTB1.Text = Convert.ToString(long1);
            ulong1 = ulong.MinValue; ULongTB1.Text = Convert.ToString(ulong1);
            float1 = float.MinValue; FloatTB1.Text = Convert.ToString(float1);
            double1 = double.MinValue; DoubleTB1.Text = Convert.ToString(double1);
            decimal1 = decimal.MinValue; DecimalTB1.Text = Convert.ToString(decimal1);




        }

        private void BtnMaximum_Click(object sender, EventArgs e)
        {
            byte byte1, byte2, byte3;
            sbyte sbyte1, sbyte2, sbyte3;
            short short1, short2, short3;
            ushort ushort1, ushort2, ushort3;
            int int1, int2, int3;
            uint uint1, uint2, uint3;
            long long1, long2, long3;
            ulong ulong1, ulong2, ulong3;
            float float1, float2, float3;
            double double1, double2, double3;
            decimal decimal1, decimal2, decimal3;

            byte2 = byte.MaxValue; ByteTB2.Text = Convert.ToString(byte2);
            sbyte2 = sbyte.MaxValue; SByteTB2.Text = Convert.ToString(sbyte2);
            short2 = short.MaxValue; ShortTB2.Text = Convert.ToString(short2);
            ushort2 = ushort.MaxValue; UShortTB2.Text = Convert.ToString(ushort2);
            int2 = int.MaxValue; IntTB2.Text = Convert.ToString(int2);
            uint2 = uint.MaxValue; UIntTB2.Text = Convert.ToString(uint2);
            long2 = long.MaxValue; LongTB2.Text = Convert.ToString(long2);
            ulong2 = ulong.MaxValue; ULongTB2.Text = Convert.ToString(ulong2);
            float2 = float.MaxValue; FloatTB2.Text = Convert.ToString(float2);
            double2 = double.MaxValue; DoubleTB2.Text = Convert.ToString(double2);
            decimal2 = decimal.MaxValue; DecimalTB2.Text = Convert.ToString(decimal2);
        }

        private void Input1TextChanged(object sender, EventArgs e)
        {



            try
            {
                byte1 = Convert.ToByte(input1textbox.Text);
                ByteTB1.Text = byte1.ToString();
            }
            catch (Exception) {ByteTB1.Text = "error"; byte1 = 0; }
            try
            {
                sbyte1 = Convert.ToSByte(input1textbox.Text);
                SByteTB1.Text = sbyte1.ToString();
            }
            catch (Exception) { SByteTB1.Text = "error"; sbyte1 = 0; }
            try
            {
                short1 = Convert.ToInt16(input1textbox.Text);
                ShortTB1.Text = short1.ToString();
            }
            catch (Exception) { ShortTB1.Text = "error"; short1 = 0; }
            try
            {
                ushort1 = Convert.ToUInt16(input1textbox.Text);
                UShortTB1.Text = ushort1.ToString();
            }
            catch (Exception) { UShortTB1.Text = "error"; ushort1 = 0; }
            try
            {
                int1 = Convert.ToInt32(input1textbox.Text);
                IntTB1.Text = int1.ToString();
            }
            catch (Exception) { IntTB1.Text = "error"; int1 = 0; }
            try
            {
                uint1 = Convert.ToUInt32(input1textbox.Text);
                UIntTB1.Text = uint1.ToString();
            }
            catch (Exception) { UIntTB1.Text = "error"; uint1 = 0; }
            try
            {
                long1 = Convert.ToInt64(input1textbox.Text);
                LongTB1.Text = long1.ToString();
            }
            catch (Exception) { LongTB1.Text = "error"; long1 = 0; }
            try
            {
                ulong1 = Convert.ToUInt64(input1textbox.Text);
                ULongTB1.Text = ulong1.ToString();
            }
            catch (Exception) { ULongTB1.Text = "error"; ulong1 = 0; }
            try
            {
                float1 = Convert.ToSingle(input1textbox.Text);
                FloatTB1.Text = float1.ToString();
            }
            catch (Exception) { FloatTB1.Text = "error"; float1 = 0.0f; }
            try
            {
                double1 = Convert.ToDouble(input1textbox.Text);
                DoubleTB1.Text = double1.ToString();
            }
            catch (Exception) { DoubleTB1.Text = "error"; double1 = 0; }
            try
            {
                decimal1 = Convert.ToDecimal(input1textbox.Text);
                DecimalTB1.Text = decimal1.ToString();
            }
            catch (Exception) { DecimalTB1.Text = "error"; decimal1 = 0.0m; }




        }
    }
}
