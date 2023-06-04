-- Table: public.statistics

-- DROP TABLE public.statistics;

CREATE TABLE public.statistics
(
    id integer NOT NULL GENERATED BY DEFAULT AS IDENTITY ( INCREMENT 1 START 1 MINVALUE 1 MAXVALUE 2147483647 CACHE 1 ),
    date date NOT NULL,
    views integer,
    clicks integer,
    cost numeric,
    cpc numeric,
    cpm numeric,
    CONSTRAINT pk_statistics PRIMARY KEY (id)
)

TABLESPACE pg_default;

ALTER TABLE public.statistics
    OWNER to postgres;