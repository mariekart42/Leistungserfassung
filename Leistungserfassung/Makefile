.PHONY: all build up down clean fclean

all: build up

build: 
	docker-compose build

up:
	@if [ -f ".env" ]; then \
		docker-compose up -d; \
	else echo "env file does not exist. Exit Program ..."; fi

re: fclean all

down:
	docker-compose down --remove-orphans

clean: down
	docker image rm -f lef_image

fclean: clean
	docker volume rm db_volume