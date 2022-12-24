select * from education_Relief_donor
select * from flood_Relief_donor

select * from tbl_user
select * from donor_data
select * from flood_relief_donor UNION select * from education_relief_donor
CREATE TABLE rep (
    cnic varchar(255),
    firstName varchar(255),
    lastName varchar(255),
    email varchar(255),
    password varchar(255),
	phone varchar(255),
	income varchar(255),
	familymember varchar(255),
	location varchar(255)
);
CREATE TABLE tbl_user (
    cnic varchar(255),
    password varchar(255)
);

CREATE TABLE volunteer_data (
    cnic varchar(255),
    firstName varchar(255),
    lastName varchar(255),
    email varchar(255),
    password varchar(255),
	phone varchar(255)
);
CREATE TABLE PR_data (
    cnic varchar(255),
    firstName varchar(255),
    lastName varchar(255),
    TAX varchar(255),
    FIR varchar(255),
	Court_Case varchar(255)
);


select * from Flood_Relief_volunteer

select * from Flood_Relief_donor