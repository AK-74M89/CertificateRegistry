CREATE TABLE public.organization (
  id INTEGER DEFAULT nextval('organization_id_seq'::regclass) NOT NULL, 
  name VARCHAR(255) NOT NULL, 
  CONSTRAINT organization_pkey PRIMARY KEY(id)
) WITHOUT OIDS;

ALTER TABLE public.organization
  ALTER COLUMN id SET STATISTICS 0;

ALTER TABLE public.organization
  ALTER COLUMN name SET STATISTICS 0;