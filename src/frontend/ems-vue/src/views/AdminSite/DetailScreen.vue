<template>
  <div>
    <v-row v-if="event">
      <v-col cols="12" class="d-flex align-start">
        <div>
          <h2 class="font-weight-bold text-uppercase">{{ event.name }}</h2>
          <p class="text-caption">by: {{ event.createdBy }}</p>
        </div>
        <div class="pt-1">
          <v-chip class="rounded-lg mx-1" size="x-small" variant="elevated" color="#7CB518">
            <v-icon size="small">mdi-alarm</v-icon><span>start at {{ event.startedDate }}</span>
          </v-chip>
          <v-chip class="rounded-lg mx-1" size="x-small" variant="elevated" color="#FF7F00">
            <p>{{ event.category.name }}</p>
          </v-chip>
        </div>
      </v-col>
      <v-col cols="12">
        <v-row>
          <v-col cols="4">
            <v-img
              src="https://blogger.googleusercontent.com/img/b/R29vZ2xl/AVvXsEgyPOjxjl0l0xUIdDF8JbrVgPN8W4Wh79jpEy1YQYAtagSfZKVuwKkpJRQcFvNIiy36lgwMn56dN4oBdNqmsxHzKZzdXm630fkiNwnSzwpsds_uetpWB6jAsCGSuAqUEFooGPftVy387jM/s1600/rupp.jpg"
              width="100%"
              class="rounded-lg"
              cover
              :aspect-ratio="1"
            />
          </v-col>
          <v-col cols="4">
            <v-img
              class="rounded-lg"
              src="https://www.rupp.edu.kh/ifl/english/image_banner/img_ifl_doe.jpg"
              :aspect-ratio="1"
              width="100%"
              cover
            />
          </v-col>
          <v-col cols="4">
            <v-row>
              <v-col cols="12">
                <v-img
                  src="https://www.researchgate.net/publication/335101723/figure/fig1/AS:790482535870464@1565477131379/Royal-University-of-Phnom-Penhs-main-building-Building-A.jpg"
                  max-width="190"
                  class="rounded-lg"
                />
              </v-col>
              <v-col cols="12">
                <v-img
                  src="https://www.researchgate.net/publication/335101723/figure/fig1/AS:790482535870464@1565477131379/Royal-University-of-Phnom-Penhs-main-building-Building-A.jpg"
                  max-width="190"
                  class="rounded-lg"
                />
              </v-col>
            </v-row>
          </v-col>
          <v-col cols="12" class="d-flex justify-center">
            <v-card
              min-width="110"
              class="mx-2 pa-2 d-flex align-center flex-column smallDetailBox"
            >
              <v-icon size="x-large" color="#004B8D"> mdi-account-group-outline </v-icon>
              <p>Participator</p>
              <p>{{ event.numberOfParticipant }}</p>
            </v-card>
            <v-card
              min-width="110"
              class="mx-2 pa-2 d-flex flex-column align-center smallDetailBox"
            >
              <v-icon size="x-large" color="#004B8D"> mdi-glasses </v-icon>
              <p>viewers</p>
              <p>{{ event.numberOfParticipant }}</p>
            </v-card>
            <v-card
              min-width="110"
              class="mx-2 pa-2 d-flex flex-column align-center smallDetailBox"
            >
              <v-icon size="x-large" color="#004B8D"> mdi-clipboard-text-outline </v-icon>
              <p>Session</p>
              <p><v-btn variant="text" text="view"></v-btn></p>
            </v-card>
          </v-col>
          <v-col cols="12">
            <h3 class="font-weight-bold">Description</h3>
            <p>
              {{ event.description }}
            </p>
          </v-col>
          <v-col cols="6">
            <v-row>
              <v-col cols="12" class="d-flex">
                <p><span class="font-weight-bold">Start Date: </span>{{ event.startedDate }}</p>
              </v-col>
              <v-col cols="12">
                <p><span class="font-weight-bold">End Date: </span>{{}}</p>
              </v-col>
              <v-col cols="12">
                <p><span class="font-weight-bold">Time: </span>8:30 AM</p>
              </v-col>
              <v-col cols="12">
                <p><span class="font-weight-bold">Map: </span>{{ event.venue.name }}</p>
              </v-col>
            </v-row>
          </v-col>
          <v-col cols="6">
            <iframe
              :src="event.venue.googleMapUrl"
              width="100%"
              height="200"
              style="border: 0"
              allowfullscreen=""
              loading="lazy"
              referrerpolicy="no-referrer-when-downgrade"
            >
            </iframe>
          </v-col>
          <v-col cols="12" class="d-flex justify-end">
            <v-btn @click="deleteEventById" class="mx-2" color="#004B8D">
              <v-icon> mdi-delete </v-icon>
              Delete
            </v-btn>
            <v-btn color="#FF7F00">
              <v-icon> mdi-pen </v-icon>
              Edit
            </v-btn>
          </v-col>
        </v-row>
      </v-col>
    </v-row>
  </div>
</template>
<script>
import { useRoute } from 'vue-router'
import { ref, watch } from 'vue'
import { onMounted } from 'vue'
import axios from 'axios'

export default {
  setup() {
    const route = useRoute() // 2
    const event = ref(null) // 3

    async function deleteEventById() {
      const result = await axios.delete(`http://localhost:4001/api/v1/event/${route.params.id}`)
      if (result.data.success === true) {
        window.location = '/admin/all-events'
      }
    }

    async function fetchEventById() {
      const result = await axios.get(`http://localhost:4001/api/v1/event/${route.params.id}`)
      event.value = result.data
      console.log(result.data)
    }

    onMounted(async () => {
      await fetchEventById()
    })

    return {
      deleteEventById,
      event
    }
  }
}
</script>

<style>
.smallDetailBox {
  border: 1px solid rgba(255, 127, 0, 0.2);
  box-shadow: 2px 5px 1px rgba(255, 127, 0, 0.2);
}
</style>
