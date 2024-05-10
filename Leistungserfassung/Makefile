.PHONY: all build up down clean fclean

all: build up

build: 
	docker-compose build

up:
	@if [ -f ".env" ]; then \
		docker-compose up -d; \
		echo "\n\033[0;32m: DATABASE IS READY TO ACCEPT CONNECTION\033[0m"; \
	else echo ": ! env file does not exist. Exit Program ..."; fi

re: fclean all

down:
	@docker-compose down --remove-orphans
	@echo "\033[0;34m: container is down\033[0m"

clean: down
	@docker image rm -f lef_image 2>/dev/null || true
	@echo "\033[0;31m: ! removed lef_image\033[0m"

fclean: clean
	@docker volume rm -f db_volume >/dev/null 2>&1 || true
	@echo "\033[0;31m: ! removed db_volume\033[0m"
