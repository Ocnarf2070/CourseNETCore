-- Creation of the schema and table
create database school;
create table school.studient(
id int unsigned auto_increment primary key,
nid varchar(50) not null,
`name` varchar(50) not null,
surname varchar(50) not null,
email varchar(50) not null,
image longblob
);

-- Creation of users and roles
create role 'app_role';
grant insert, update, delete on school.* to 'app_role';
create user 'app1'@'localhost' identified by 'app1pass';
grant 'app_role' to 'app1'@'localhost';
SET DEFAULT ROLE ALL TO 'app1'@'localhost';
flush privileges;