import pandas as pd
import glob
import argparse

ap = argparse.ArgumentParser()
ap.add_argument("-t","--total_data", type=int, required=True,
	help="Total sample per conditions")
ap.add_argument("-v","--tipe", required=True,
	help="Adaptive or Fixed")
args = ap.parse_args()

files = glob.glob('*.csv')

li = []
for filename in files:
    df = pd.read_csv(filename)
    li.append(df)

frame = pd.concat(li, axis=1, ignore_index=True)


frame_1 = frame[:args.total_data]

new_frame = frame_1.drop([0,4,8,12,16,20,24,28,32,36,], axis=1)

new_frame['data_kecepatan_total'] = new_frame[1]+new_frame[5]+new_frame[9]+new_frame[13]+new_frame[17]+new_frame[21]+new_frame[25]+new_frame[29]+new_frame[33]+new_frame[37]
new_frame['data_kecepatan_rata2'] = new_frame[1]+new_frame[5]+new_frame[9]+new_frame[13]+new_frame[17]+new_frame[21]+new_frame[25]+new_frame[29]+new_frame[33]+new_frame[37]
new_frame['data_stop_total'] = new_frame[1+1]+new_frame[5+1]+new_frame[9+1]+new_frame[13+1]+new_frame[17+1]+new_frame[21+1]+new_frame[25+1]+new_frame[29+1]+new_frame[33+1]+new_frame[37+1]
new_frame['data_stop_rata2'] = new_frame[1+1]+new_frame[5+1]+new_frame[9+1]+new_frame[13+1]+new_frame[17+1]+new_frame[21+1]+new_frame[25+1]+new_frame[29+1]+new_frame[33+1]+new_frame[37+1]
new_frame['data_delay_total'] = new_frame[1+2]+new_frame[5+2]+new_frame[9+2]+new_frame[13+2]+new_frame[17+2]+new_frame[21+2]+new_frame[25+2]+new_frame[29+2]+new_frame[33+2]+new_frame[37+2]
new_frame['data_delay_rata2'] = new_frame[1+2]+new_frame[5+2]+new_frame[9+2]+new_frame[13+2]+new_frame[17+2]+new_frame[21+2]+new_frame[25+2]+new_frame[29+2]+new_frame[33+2]+new_frame[37+2]
for i in range (len(new_frame['data_kecepatan_total'])):
    new_frame['data_stop_rata2'][i] = new_frame['data_stop_total'][i] / 10
    new_frame['data_delay_rata2'][i] = new_frame['data_delay_total'][i] / 10
    new_frame['data_kecepatan_rata2'][i] = new_frame['data_kecepatan_total'][i] / 10

##new_frame.to_excel("Data_Rata2_Pengujian.xlsx")
data = [new_frame['data_delay_rata2'],new_frame['data_stop_rata2'],new_frame['data_kecepatan_rata2']]
frame2 = pd.concat(data, axis=1)
frame2.to_excel("Data_Pengujian "+args.tipe+".xlsx")




