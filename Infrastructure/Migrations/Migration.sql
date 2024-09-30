create database library_db;

create table books(
	id uuid primary key default gen_random_uuid(),
	title varchar(255) not null,00
	description varchar(255),
	isbn varchar(255) unique,
	publisheddate date,
	authorid uuid references authors (id),
	categoryid uuid references categories (id),
	createdat date
);
create table authors(
	id uuid primary key default gen_random_uuid(),
	firstname varchar(255),
	lastname varchar(255),
	dateofbirth date,
	biography varchar(255),
	createdat date
);
create table categories(
	id uuid primary key default gen_random_uuid(),
	name varchar(255) unique,
	createdat date
);
create table bookrental(
	id uuid primary key default gen_random_uuid(),
	bookid uuid references books (id),
	userid uuid references users (id),
	rentaldate date,
	returndate date,
	createdat date
);
create table users(
	id uuid primary key default gen_random_uuid(),
	username varchar(255) unique,
	email varchar(255) unique,
	passwordhash varchar(255),
	createdat date
);