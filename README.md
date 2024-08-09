# AerobaticLogger
Project to log glider aerobatic flights for later replay and analysis, with a view to potential automatic live scoring. GPS time and location, IMU with minimum 9DOF, and barometric pressure for altitude. 

The logger we intend to use is provided by Gulf Coast Data Concepts. The project is sponsored by British Aerobatics. 

https://www.gulfcoastdataconcepts.com/IMU-GPS.html

https://www.aerobatics.org.uk

The logger is configured using a simple text file called config.txt located on the microSD card.

Data is stored to simple text formatted .csv type files, which are easily imported into any spreadsheet or analysis software (Matlab, Octave, R, etc). Below is a example data file:

   
        ;Title, http://www.gcdataconcepts.com, LSM6DSM, BMP384, GPS
        ;Version, 2476, Build date, Apr 17 2023,  SN:CCDC20235263491
        ;Start_time, 2023-05-31, 22:09:12.819
        ;Uptime, 5,sec,  Vbat, 4194, mv, EOL, 3500, mv
        ;Deadband, 0, counts
        ;DeadbandTimeout, 5.000,sec
        ;LSM6DSM, SR,104,Hz, Units, mG, mdps, fullscale gyro 250dps, accel 4g
        ;Magnetometer, SR,10,Hz, Units, nT, Temperature, 37,degC
        ;BMP384, SI, 0.100,sec, Units, Pa, mdegC
        ;Alt Trigger disabled
        ;CAM_M8 Gps, SR,1,Hz
        ;Gps Sats, TOW, 0, ver, 0, numSat, 0
        ;, gnssId, svId, cno, elev, azmith, prRes, flags,inUse
        ;Time, Ax, Ay, Az, Gx, Gy, Gz, Mx, My, Mz, P, T
        1685570953.732178,18,-12,1012,-866,-2328,-132,52734,3735,2868,101368,39951
        1685570953.741470,17,-12,1015,-813,-2442,-167
        1685570953.750762,17,-13,1016,-866,-2363,-184
        1685570953.760054,17,-12,1014,-857,-2450,-202
        1685570953.769346,18,-13,1014,-857,-2415,-245
        1685570953.778638,18,-12,1014,-840,-2407,-219
        1685570953.787930,18,-12,1014,-813,-2450,-219
        1685570953.797222,17,-11,1014,-831,-2459,-167
        1685570953.806519,18,-13,1014,-805,-2380,-210,52819,3509,2966,101366,39945,, 356975.000, 30.3602812,-89.1171477, -16.325,11.320, 283.780,200.663
        1685570953.815811,18,-11,1014,-866,-2372,-167
        1685570953.825103,18,-12,1015,-866,-2407,-167
        1685570953.834395,17,-12,1015,-875,-2424,-140
        1685570953.843687,19,-13,1015,-822,-2407,-193
        1685570953.852979,18,-12,1014,-848,-2407,-202
        1685570953.862271,18,-12,1015,-892,-2407,-158
        1685570953.871563,17,-13,1014,-875,-2354,-202
        1685570953.880860,18,-12,1014,-778,-2459,-167,,,,101370,39936
        1685570953.890152,18,-12,1016,-735,-2494,-193
        1685570953.899444,18,-11,1015,-621,-2564,-219

        The bulk of the work will be processing the logged data through to flight simulator play-back files, say Condor 2 file format, and also GPS position and aircraft attitude v UTC time files for flight analysis against the CIVA competition judging rules. This is the major piece of work that no one has tackled - yet. There is a paper  on a unit trialed during a Red Bull Air Race that used Kalman Filtering with 43 degrees of freedom, so it is not simple!

        https://www.imar-navigation.de/downloads/papers/REP_iMAR_Paper_TrainingAircraft_2016-RedBull.pdf

        
