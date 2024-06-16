<template>
    <v-card class="Event_card pa-3" color="#d9d9d970" @click="onClickCard">
      <v-row>
        <v-col cols="12" class="d-flex justify-end align-center">
          <v-chip class="rounded-lg" size="x-small" variant="elevated" color="#7CB518">
            <v-icon size="small">mdi-alarm</v-icon><span>Starts at {{ event.time }}</span>
          </v-chip>
        </v-col>
        <v-col cols="12" class="pb-0">
          <v-img :src="event.image[0]" max-height="150"></v-img>
        </v-col>
        <v-col cols="12" class="pb-0">
          <h3 class="font-weight-bold text-uppercase" style="color: #004B8D">{{ event.name }}</h3>
        </v-col>
        <v-col cols="12" class="pb-0">
          <p><v-icon color="#004B8D">mdi-map-marker-radius-outline</v-icon>{{ event.location }}</p>
        </v-col>
        <v-col cols="12" class="pb-0">
          <p><v-icon color="#004B8D">mdi-account-multiple</v-icon> {{ event.participators }} Subscribes</p>
        </v-col>
        <v-col cols="12">
          <v-chip class="rounded-lg" size="x-small" variant="elevated" color="#FF7F00">
            <p> {{ event.tag }}</p>
          </v-chip>
        </v-col>
      </v-row>  
    </v-card>
  </template>
  <script>
  export default {
    props: {
      event: {
        type: Object,
        required: true
      }
    },
    methods: {
      onClickCard() {
        // You can navigate to a detail screen or perform other actions here
        this.$router.push(`/admin/detail-screen/${this.event.id}`);
      }
    }
  }
  </script>
  
  <style scoped>
  .Event_card {
    border: 1px solid rgba(255, 127, 0, 0.2);
    box-shadow: 2px 5px 1px rgba(255, 127, 0, 0.2);
  }
  </style>
  
