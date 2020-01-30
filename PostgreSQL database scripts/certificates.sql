CREATE DATABASE certificates
    WITH 
    OWNER = postgres
    ENCODING = 'WIN1251'
    LC_COLLATE = 'Russian_Russia.1251'
    LC_CTYPE = 'Russian_Russia.1251'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1;

GRANT ALL ON DATABASE certificates TO postgres;

GRANT TEMPORARY, CONNECT ON DATABASE certificates TO certificates_users;